#ifndef __global_h
#define __global_h

#include <avr/io.h>

#define XTAL		8000000L    // Crystal frequency in Hz

void setTime(uint8_t h, uint8_t m, uint8_t s, uint16_t ms);

#endif
