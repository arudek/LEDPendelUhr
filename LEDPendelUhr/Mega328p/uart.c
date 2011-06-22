#include "uart.h"
#include <stdio.h>
#include <stdlib.h>

static volatile char USART_buffer[255];

#define UART_changeTimeSettings	0
#define UART_changeTextSettings 1
#define UART_changeTime 2
#define UART_changeText 3

/*
	0:	Aktion 
			0=Einstellungen für Uhrzeit ändern
			1=Einstellungen für Text ändern
			2=Uhrzeit stellen
			3=Text ändern
	1:	1=Neue Werte in EEPROM sichern
	2-...: Daten:
		Aktion=0 oder 1:
			11 Bytes (struct ledText_type)
		Aktion=2:
			5 Bytes (Stunde, Minute, Sekunde, Milisekunden (2 Bytes))
		Aktion=3:
			255 Bytes (Text, Ende mit 0 gekennzeichnet)
*/
void USART_RX_INT()
{
	uint8_t bufSettings[sizeof(ledText_Type)];
	uint8_t bufText[255];
	uint8_t bufTime[5]; 		//HMSms

	uint8_t action = USART_Receive();
	uint8_t writeToEEPROM = USART_Receive();

	switch (action)
	{
		case UART_changeTimeSettings:
		case UART_changeTextSettings:
			USART_receiveBlock((uint8_t*)&bufSettings,sizeof(ledText_Type));
			changeSettings(action, bufSettings);
			if (writeToEEPROM!=0)
				writeSettingsToEEPROM(action);
			break;
		case UART_changeTime:
			USART_receiveBlock((uint8_t*)&bufTime,5);
			setTime(bufTime[0], bufTime[1], bufTime[2], (uint16_t) (bufTime[3] + (bufTime[4]<<8)));
			break;
		case UART_changeText:
			USART_receiveBlock((uint8_t*)&bufText, 255);
			changeCustomText((char*)bufText);	
			if (writeToEEPROM!=0)
				writeTextToEEPROM();
			break; 
	}


/*	int size = sizeof(ledText_Type);
	uint8_t buf[sizeof(ledText_Type)];
	for (int i=0;i<size;i++)
	{
		buf[i]=USART_Receive();
	}
	changeText(buf);*/
/*
	USART_receiveString((char*)buf);

	char ret[50];
	sprintf((char*)ret, "%d Zeichen empfangen.", strlen((char*)USART_buffer));
	USART_sendString(ret);
	changeText((char*)USART_buffer);
*/
}

void USART_Init()
{
	unsigned int ubrr = UBRR_VAL;
	/*Set baud rate */
	UBRR0H = (unsigned char)(ubrr>>8);
	UBRR0L = (unsigned char)ubrr;
	/*Enable receiver and transmitter  and interrrupts*/
	UCSR0B = (1<<RXEN0)|(1<<TXEN0) | (1<<RXCIE0);
	/* Set frame format: 8data, 2stop bit */
	UCSR0C = (1<<USBS0)|(3<<UCSZ00);
}



unsigned char USART_Receive( void )
{
	/* Wait for data to be received */
	while ( !(UCSR0A & (1<<RXC0)) )
		;
	/* Get and return received data from buffer */
	return UDR0;
}

void USART_Transmit( unsigned char data )
{
	/* Wait for empty transmit buffer */
	while ( !( UCSR0A & (1<<UDRE0)) )
		;
	/* Put data into buffer, sends the data */
	UDR0 = data;
}

void USART_receiveBlock(uint8_t *buf, int size)
{
	for (int i=0;i<size;i++)
	{
		*(buf+i)=(uint8_t)USART_Receive();
	}
}

void USART_receiveString(char *buf)
{
	unsigned char c=USART_Receive();
	int i;
	for (i=0;i<255 && c>0;i++)
	{
		*(buf+i)=c;
		c=USART_Receive();
	}
	*(buf+i)=0;
}

void USART_sendString(char *buf)
{
	while (*(buf)!=0)
	{
		USART_Transmit(*(buf));
		buf++;
	}
}
