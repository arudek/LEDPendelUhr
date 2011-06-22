using System;
using System.Collections.Generic;
using System.Text;

namespace LEDPendelUhr
{
    class LEDText
    {
        public UInt16 ticks2Begin;		// Wartepause vor erstem Zeichen (in Ticks)
        public UInt16 ticks2End;			// Ticks bis zum letzten Zeichen (ab Seqúenz-Start)
        public char ticksBetween;		// Leucht-Dauer (in Ticks)
        public UInt16 ticksPerScroll;	// Anzahl Ticks für 1 Scrollspalte (0= kein Scrollen)
        public Byte scrollSpeed;		// Scroll-Geschwindigkeit (in Zeichen-Spalten pro Scroll-Intervall)
        public Byte charWidth;			// Breite der Zeichen
        public Byte charSpace;			// Abstand zwischen 2 Zeichen (in Ticks)
        public Byte repeat;				// Zeichenfolge immer wieder von vorne beginnen

        public void appendArray(ref Byte[] dest, Byte[] arr, int size)
        {
            int l1 = dest.Length;
            Array.Resize(ref dest, l1 + size);
            Array.Copy(arr, 0, dest, l1, size);
        }

        public Byte[] getByteArray()
        {
            byte[] arr = BitConverter.GetBytes(ticks2Begin);
            appendArray(ref arr, BitConverter.GetBytes(ticks2End),2);
            appendArray(ref arr, BitConverter.GetBytes(ticksBetween),1);
            appendArray(ref arr, BitConverter.GetBytes(ticksPerScroll),2);
            appendArray(ref arr, BitConverter.GetBytes(scrollSpeed),1);
            appendArray(ref arr, BitConverter.GetBytes(charWidth),1);
            appendArray(ref arr, BitConverter.GetBytes(charSpace),1);
            appendArray(ref arr, BitConverter.GetBytes(repeat),1);
            return arr;
        }
    }

}
