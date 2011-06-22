#include "global.h"

#include <inttypes.h>
#include <string.h>
#include <avr/interrupt.h>


#include "dcf77.h"
#include "ledText.h"
#include "uart.h"



#define PRESCALER_T0 8
#define TIMER_FREQ_T0	12000L		// 2000Hz (0,5ms)
#define INT_TIMER_T0 (XTAL/PRESCALER_T0/TIMER_FREQ_T0)

#define PRESCALER_T1 256
#define TIMER_FREQ_T1	1000			// 100Hz 1:10ms
#define INT_TIMER_T1 (XTAL/PRESCALER_T1/TIMER_FREQ_T1)	

static volatile int ms;
static volatile uint8_t hours;
static volatile uint8_t minutes;
static volatile uint8_t seconds;



int main(void)
{
	// Port C konfigurieren (LEDs 0-5): 
	PORTC = 0x0; 
    DDRC  = 0b00111111;       // PortC (LEDs) auf Ausgang 
	
	// PortD.6,7=LED6,7
	// Rest auf Eingang
	PORTD=0b00111111; 		//pullups hoch
	DDRD =0b11000000;		// PortD0-5 auf Eingang

	EICRA = (1<<ISC01) | (0<<ISC00);	// on falling edge
//	EICRA = (1<<ISC01) | (1<<ISC00);	// on rising edge
	EIMSK = (1<<INT0);					// enable int0


	// Port B konfigurieren (Taster):
	DDRB = 0;				// PortB auf Eingang
	PORTB |= (1<<PORTB0);	// pullup an PCINT0 (T1) hoch
	PORTB |= (1<<PORTB1);	// pullup an PCINT1 (T2) hoch
	
	// Timer 0 konfigurieren (LEDs):
	TCCR0B |= (1<<CS01); 	// Prescaler 8
	TCCR0A |= (1<<WGM01);				// CTC (Counter läuft nur bis OCRA)
//	TCCR0A |= (1<<COM0A1);				// Kein Signal auf PortD6 ausgeben
	OCR0A = INT_TIMER_T0;				// für LEDs
	TIMSK0 |= (1<<OCIE0A);				

	// Timer 1 konfigurieren (Funkuhr):
    TCCR1B |= (1<<CS12) | (1<<WGM12);	// CS12: CLK/256; WGM12: Limit in OCR1A definiert (CTC)
	OCR1A = INT_TIMER_T1;   			// Timer auf 10ms
	TIMSK1  |= (1<<OCIE1A);				// Int, wenn TCNT1==OCR1A	            

/*	// Timer 2 konfigurieren (RTC):
//	TCCR2A |= (1<<WGM21);	// CTC
	TCCR2B |= (0<<CS22) | (1<<CS20) | (1<<CS21);	// prescaler 64
	TIMSK2 |= (1<<TOIE2);
	//ASSR |= (1<<EXCLK);		// Oszillator statt Quarz;
	ASSR |= (1<<AS2);
*/

	
	// Pin Change Interrrupts konfigurieren (Taster):
	PCICR |= (1<<PCIE0);					// PCIE0 aktivieren (PCINT0-PCINT7)
	PCMSK0 |= (1<<PCINT0) | (1<<PCINT1);	// PCINT0-3 aktivieren


	ledText_init();

	USART_Init();


	sei();			// Interrupts aktivieren
    for (;;) {}   	// loop forever   
}

void setTime(uint8_t h, uint8_t m, uint8_t s, uint16_t millisec)
{
	hours=h;
	minutes=m;
	seconds=s;
	ms=millisec;
}

// Lichtschranke:
SIGNAL(INT0_vect)
{
	ledText_beginSequence();
	//TCNT0=0;
}

/* signal handler for external interrupt int0 */

SIGNAL(PCINT0_vect)     		// Taster
{
	uint8_t inp = PINB;

	if ((inp & (1<<PORTB0)) >0)
	{
		setTextId(0);
	}
	else if ((inp & (1<<PORTB1)) > 0)
	{
		setTextId(1);
	}

}

SIGNAL (TIMER0_COMPA_vect)    // Timer für LEDs
{
	ledText_tick();
}

SIGNAL (TIMER1_COMPA_vect)		// Timer für dcf77
{
	ms++; //=10;

	
	if (ms>999) 
	{
		ms-=1000;
		if (seconds<59)	seconds++;
		else 
		{
			seconds=0;
			if (minutes<59)
				minutes++;
			else
			{
				minutes=0;
				if (hours<23)
					hours++;
				else 
					hours=0;
			}
		}
		changeTime(hours, minutes, seconds);
	}

/*	uint8_t inp=(PIND & (1<<PORTD3));	// Pin auslesen
	dcf77_processBit(inp, (uint8_t *)&hours, (uint8_t*)&minutes, (uint8_t*)&seconds, (int*)&ms);
	TCNT1=0;
*/}

/*
SIGNAL (TIMER2_OVF_vect)		// RTC Timer
{
	if (ms<999) 
	{
		ms++;
	}
	else
	{
		ms=0;
		if (seconds<59)	seconds++;
		else 
		{
			seconds=0;
			if (minutes<59)
				minutes++;
			else
			{
				minutes=0;
				if (hours<23)
					hours++;
				else 
					hours=0;
			}
		}
		changeTime(hours, minutes, seconds);

	}

}*/

/* Interrupt für eingehende Bytes an uart */
SIGNAL (USART_RX_vect) 
{
	USART_RX_INT();
}
