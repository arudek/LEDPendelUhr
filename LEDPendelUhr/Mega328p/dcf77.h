#include <avr/io.h>
#include <stdio.h>
#include "global.h"

static volatile uint8_t m_dcf77_validData;
static volatile uint8_t m_dcf77_timer;
static volatile uint16_t m_dcf77_t10ms_counter;
static volatile uint8_t m_dcf77_pin_up;
static volatile uint8_t m_dcf77_buffer[60];
static volatile uint8_t m_dcf77_buffer_index;
static volatile uint8_t m_dcf77_gotLastBit;

void dcf77_processBit(uint8_t inp, uint8_t *hr, uint8_t *min, uint8_t *sec, int *ms);
uint8_t dcf77_getParityBit(uint8_t start, uint8_t end);
void dcf77_processTimeBuffer(uint8_t *hr, uint8_t *min, uint8_t *sec);
