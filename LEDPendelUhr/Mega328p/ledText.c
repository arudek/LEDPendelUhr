#include <stdio.h>
#include <avr/eeprom.h>
#include "ledText.h"
#include "matrix.h"


ledText_Type EEMEM EE_ledText_CustomStringSettings={
	110,	// ticks2Begin
	330,	// ticks2End
	1,		// ticksBetween
	200,	// ticksPerScroll
	2,		// scrollSpeed
	5,		// charWidth
	1,		// charSpace
	1		// repeat
	};

ledText_Type EEMEM EE_ledText_TimeSettings={
	180,	// ticks2Begin
	300,	// ticks2End
	1,		// ticksBetween
	0,		// ticksPerScroll
	0,		// scrollSpeed
	5,		// charWidth
	1,		// charSpace
	0		// repeat
	};

char EEMEM EE_ledText_CustomString[255]="   Hier koennte dein Text stehen...   ";

static volatile uint16_t ledText_tickCounter;
static volatile uint8_t ledText_tickCounter_on;	// für LEDTEXT_TICKS_BETWEEN
static volatile uint8_t	ledText_tickCounter_space;	// für CHAR_SPACE
static volatile uint8_t ledText_seqCounter;		
static volatile uint16_t ledText_scrollTicks;
static volatile uint8_t ledText_charIndex;
static volatile uint8_t ledText_charSubIndex;
static volatile uint8_t ledText_firstCharIndex;
static volatile uint8_t ledText_firstCharSubIndex;
//static volatile char time[9];

static volatile ledText_Type ledText[2];
static volatile char ledText_time[9];
static volatile char ledText_customString[255];
static volatile ledText_Type *activeText;
static volatile char *activeString;
static volatile uint8_t ledText_newTextId;

void setTextId(uint8_t id)
{
	ledText_newTextId=id;
}

void changeTime(uint8_t h, uint8_t m, uint8_t s)
{
	sprintf((char*)ledText_time, "%02d:%02d:%02d", h, m, s);
}

void changeSettings(uint8_t id, uint8_t *buf)
{
	memcpy ((uint8_t*)&ledText[id], (uint8_t*)buf, sizeof(ledText_Type));
}

void changeCustomText(char *buf)
{
	memcpy ((char*)&ledText_customString, (char*)buf, 255);

	ledText_firstCharIndex=0;
	ledText_firstCharSubIndex=0;
	ledText_seqCounter=0;
}

void writeSettingsToEEPROM(uint8_t id)
{
	switch (id)
	{
		case 0:	//time
			eeprom_write_block((const void*)&ledText[0], (void*)&EE_ledText_TimeSettings, sizeof(ledText_Type));
			break;		
		case 1:	//custom text
			eeprom_write_block((const void*)&ledText[1], (void*)&EE_ledText_CustomStringSettings, sizeof(ledText_Type));
			break;		
	}
}

void writeTextToEEPROM()
{
	eeprom_write_block((const void*)&ledText_customString, (void*)&EE_ledText_CustomString, 255);
}

void ledText_init()
{
	// Uhrzeit und custom-text aus EEPROM lesen:
	eeprom_read_block((void*)&ledText[0], (const void*)&EE_ledText_TimeSettings, sizeof(ledText_Type));
	eeprom_read_block((void*)&ledText[1], (const void*)&EE_ledText_CustomStringSettings, sizeof(ledText_Type));
	eeprom_read_block((void*)&ledText_customString, (const void*)&EE_ledText_CustomString, 255);

/*

	// Uhrzeit:
	ledText[0].ticks2Begin	=180;
	ledText[0].ticks2End	=300;	
	ledText[0].ticksBetween	=1;
	ledText[0].ticksPerScroll	=0;
	ledText[0].charWidth	=5;	
	ledText[0].charSpace	=0;	
	ledText[0].repeat		=0;		
//	ledText[0].text			="00:00:00";
	sprintf((char*)ledText[0].text, "00:00:00");

	// Happy Birthday:
	ledText[1].ticks2Begin	=110;
	ledText[1].ticks2End	=330;	
	ledText[1].ticksBetween	=1;
	ledText[1].ticksPerScroll	=200;
//	ledText[1].scrollSpeed	=2;
	ledText[1].charWidth	=5;	
	ledText[1].charSpace	=1;	
	ledText[1].repeat		=1;		
	sprintf((char*)ledText[1].text, "   Hier koennte dein Text stehen...   ");
//	ledText[1].text			="   Hier koennte dein Text stehen...   ";

*/

	setTextId(1);

//	ledText_displayText="..."; //time; //text1; //exampleText;
//	ledText_newDisplayText=ledText_displayText;
//	ledText_displayText=text1; //exampleText;

	activeText=&ledText[ledText_newTextId];
	switch (ledText_newTextId)
	{
		case 0: activeString = ledText_time; break;
		case 1: activeString = ledText_customString; break;
	}

	ledText_firstCharIndex=0;
	ledText_firstCharSubIndex=0;
	ledText_seqCounter=0;

	ledText_beginSequence();
}

void ledText_beginSequence()
{
	if (ledText_tickCounter < 50)
		return;


	// Prüfen, ob Text ausgetauscht werden soll
	if (activeText!=&ledText[ledText_newTextId])
	{
		activeText=&ledText[ledText_newTextId];
		switch (ledText_newTextId)
		{
			case 0: activeString = ledText_time; break;
			case 1: activeString = ledText_customString; break;
		}

		ledText_firstCharIndex=0;
		ledText_firstCharSubIndex=0;
		ledText_seqCounter=0;
	}

	// Sequenz bei 0 starten
	ledText_tickCounter=0;
	ledText_tickCounter_on=(*activeText).ticksBetween;
	ledText_tickCounter_space=(*activeText).charSpace;

/*
	if (ledText_seqCounter>=(*activeText).seq2Scroll)
	{
		ledText_seqCounter=0;

		ledText_firstCharSubIndex += (*activeText).scrollSpeed;

		if (ledText_firstCharSubIndex>=(*activeText).charWidth)
		{
			ledText_firstCharSubIndex-=(*activeText).charWidth;
			if (ledText_firstCharIndex>=strlen((char*)(*activeText).text)-1)
				ledText_firstCharIndex=0;
			else
				ledText_firstCharIndex++;
		}
	}
	else
		ledText_seqCounter++;
*/
	ledText_charIndex=ledText_firstCharIndex;
	ledText_charSubIndex=ledText_firstCharSubIndex;

}

char swapByte(char c)
{
	char c2=0;
	uint8_t i,j;
	for (i=0,j=7;i<8;i++,j--)
		c2 |= ((c & (1<<j)) >> j) << i;

	return c2;
}

void ledText_setPort(uint8_t val)
{
	PORTC=(val & 0b00111111);
	PORTD&=0b00111111;	// Bit 6 und 7 löschen
	PORTD|=(val & 0b11000000); // Bit 6 und 7 setzen
}

void ledText_tick()
{
	if ((*activeText).ticksPerScroll>0)
	{
		if (ledText_scrollTicks>(*activeText).ticksPerScroll)
		{
			ledText_scrollTicks=0;

			ledText_firstCharSubIndex += (*activeText).scrollSpeed;
			while (ledText_firstCharSubIndex >= (*activeText).charWidth)
			{
				ledText_firstCharSubIndex-=(*activeText).charWidth;
				if (ledText_firstCharIndex>=strlen((char*)activeString)-1)
					ledText_firstCharIndex=0;
				else
					ledText_firstCharIndex++;
			}


/*			ledText_firstCharSubIndex ++;

			if (ledText_firstCharSubIndex>=(*activeText).charWidth)
			{
				ledText_firstCharSubIndex-=(*activeText).charWidth;
				if (ledText_firstCharIndex>=strlen((char*)activeString)-1)
					ledText_firstCharIndex=0;
				else
					ledText_firstCharIndex++;
			}
*/			
			ledText_charSubIndex++;
		}
		else
			ledText_scrollTicks++;
	}


	if (ledText_tickCounter>=(*activeText).ticks2Begin && ledText_tickCounter<=(*activeText).ticks2End)
	{
		// in dieser Lücke darf Text angezeigt werden
		if (ledText_tickCounter_on>(*activeText).ticksBetween)
		{
			ledText_setPort(0);
			if (ledText_tickCounter_space>(*activeText).charSpace)
			{
				if (ledText_charSubIndex<(*activeText).charWidth)
				{
					// LEDs dürfen geändert werden
					char c=activeString[ledText_charIndex];
					if (c>='a' && c<='z') c-=32;	// 'a' -> 'A'
					if (c>=' ' && c<='_')
						ledText_setPort(matrixASCII[c-' '][ledText_charSubIndex]);
					else
						ledText_setPort(0);

					ledText_charSubIndex++;
					ledText_tickCounter_on=0;
				} 
				else 
				{
					ledText_charSubIndex=0;
					if (ledText_charIndex>=strlen((char*)activeString)-1)
					{
						// Text wurde vollständig ausgegeben

						if ((*activeText).repeat==1)
						{	
							// Text wiederholen
							ledText_charIndex=0;
						}
						else 
							ledText_charIndex=strlen((char*)activeString);
					} else
						ledText_charIndex++;
						
					ledText_tickCounter_space=0;	// Abstand zwischen Zeichen einbauen
				}



			} else
			{
				ledText_setPort(0);
				ledText_tickCounter_space++;
			}
		}

	}
	else
	{
		ledText_setPort(0);
	}

	ledText_tickCounter++;
	ledText_tickCounter_on++;

//	if (ledText_tickCounter>(*activeText).ticks2End) //LEDTEXT_TICKS_TO_END)
//		ledText_beginSequence(); // DEBUG!! 
}
