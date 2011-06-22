#include "dcf77.h"
#include "ledText.h"

void dcf77_processBit(uint8_t inp, uint8_t *hr, uint8_t *min, uint8_t *sec, int *ms)
{
	m_dcf77_t10ms_counter++; 	// counter incrementieren

	if (!m_dcf77_validData && !m_dcf77_pin_up && !inp)	// Signal noch nicht synchronisiert. Warte auf 59. Bit
	{
			if (m_dcf77_t10ms_counter > 1000)	// > 1 Sekunde = Ende der Sequenz
			{
				m_dcf77_validData=1;
				m_dcf77_buffer_index=0;
				m_dcf77_gotLastBit=1;
			}
	}

	if (m_dcf77_pin_up && !inp)		// Signal hat auf low gewechselt
	{
		m_dcf77_pin_up=0;

		if (m_dcf77_validData)
		{
			if (m_dcf77_t10ms_counter < 40)
			{
				m_dcf77_validData=0;
			}
			else
				if (m_dcf77_t10ms_counter >= 150)
				m_dcf77_buffer[m_dcf77_buffer_index]=1;
			else
				m_dcf77_buffer[m_dcf77_buffer_index]=0;
		
			if (m_dcf77_buffer_index>=58)
			{
				m_dcf77_validData=0;				// Sequenz beendet
			}
			else
				m_dcf77_buffer_index++;
		}
		m_dcf77_t10ms_counter=0;
	} 
	else if (!m_dcf77_pin_up && inp)
	{
		if (m_dcf77_gotLastBit)
		{
			*ms=0;
			dcf77_processTimeBuffer(hr, min, sec);
			m_dcf77_gotLastBit=0;

		//	changeTime(*hr, *min, *sec); // DEBUG!!
		} else
		{
		/*DEBUG!!*/
		/*		if (*sec<59)	
					*sec = (*sec) + 1;
				else 
				{
					*sec=0;
					if (*min<59)
						*min = (*min) + 1;
					else
					{
						*min=0;
						if (*hr<23)
							*hr = (*hr) + 1;
						else 
							*hr=0;
					}
				}
				changeTime(*hr, *min, *sec);*/

		/*DEBUG!!*/
		}


		m_dcf77_pin_up=1;
		m_dcf77_t10ms_counter=0;

	}

}


uint8_t dcf77_getParityBit(uint8_t start, uint8_t end)
{
//	char *buf = (char*)buffer;
	uint8_t sum=0;
	for (int i=start;i<=end;i++)
		sum += m_dcf77_buffer[i];

	if (sum==((sum>>1)<<1))
		return 0;
	
	return 1;
}

void dcf77_processTimeBuffer(uint8_t *hr, uint8_t *min, uint8_t *sec)
{
	if (!m_dcf77_validData)
		return;

	if (m_dcf77_buffer[0]!=0)	// 1. Bit muss 1 sein
		return;

	// check parity-bits:
	if (dcf77_getParityBit(21,27)!=m_dcf77_buffer[28])	// PB für Minuten falsch
		return;
	if (dcf77_getParityBit(29,34)!=m_dcf77_buffer[35])	// PB für Stunden falsch
		return;
	if (dcf77_getParityBit(36,57)!=m_dcf77_buffer[58])	// PB für Datum falsch
		return;

	uint8_t h = m_dcf77_buffer[29] + m_dcf77_buffer[30]*2 + m_dcf77_buffer[31]*4 + m_dcf77_buffer[32]*8 
			+ m_dcf77_buffer[33]*10 + m_dcf77_buffer[34]*20;
	uint8_t m = m_dcf77_buffer[21] + m_dcf77_buffer[22]*2 + m_dcf77_buffer[23]*4 + m_dcf77_buffer[24]*8 
			  + m_dcf77_buffer[25]*10 + m_dcf77_buffer[26]*20 + m_dcf77_buffer[27]*40;

	if (h>23 || m>59)
		return;
	
	*hr=h;
	*min=m;
	*sec=0;

}

