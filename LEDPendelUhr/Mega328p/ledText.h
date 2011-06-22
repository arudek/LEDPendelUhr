#ifndef __ledText_h
#define __ledText_h

#include <avr/interrupt.h>
#include <string.h>

void setTextId(uint8_t id);
void changeSettings(uint8_t id, uint8_t *buf);
void changeTime(uint8_t h, uint8_t m, uint8_t s);
void changeCustomText(char *buf);
void writeSettingsToEEPROM(uint8_t id);
void writeTextToEEPROM();
void ledText_init();
void ledText_beginSequence();
char swapByte(char c);
void ledText_setPort(uint8_t l);
void ledText_tick();

typedef struct {
	uint16_t ticks2Begin;		// Wartepause vor erstem Zeichen (in Ticks)
	uint16_t ticks2End;			// Ticks bis zum letzten Zeichen (ab Seqúenz-Start)
	uint8_t ticksBetween;		// Leucht-Dauer (in Ticks)
	uint16_t ticksPerScroll;	// Anzahl Ticks für 1 Scrollspalte (0= kein Scrollen)
	uint8_t scrollSpeed;		// Scroll-Geschwindigkeit (in Zeichen-Spalten pro Scroll-Intervall)
	uint8_t charWidth;			// Breite der Zeichen
	uint8_t charSpace;			// Abstand zwischen 2 Zeichen (in Ticks)
	uint8_t repeat;				// Zeichenfolge immer wieder von vorne beginnen
} ledText_Type;

#endif
