#include "global.h" 
#include "ledText.h"

#define BAUD 38400L //56000L //14400UL

#define UBRR_VAL ((XTAL+BAUD*8)/(BAUD*16)-1)
#define BAUD_REAL (XTAL/(16*(UBRR_VAL+1)))
#define BAUD_ERROR ((BAUD_REAL*1000)/BAUD)

#if ((BAUD_ERROR<990) || (BAUD_ERROR>1010))
	#error Systematischer Fehler der Baudrate größer 1% und damit zu hoch!
#endif

/* Prototypes */
void USART_RX_INT();
void USART_Init();
unsigned char USART_Receive( void );
void USART_Transmit( unsigned char data );
void USART_receiveBlock(uint8_t *buf, int size);
void USART_receiveString(char *buf);
void USART_sendString(char *buf);

