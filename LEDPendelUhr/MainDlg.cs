using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LEDPendelUhr
{
    public partial class MainDlg : Form
    {
        public MainDlg()
        {
            InitializeComponent();

            // set BAUD = 38400
            SLUSBXpressDLL.SI_SetBaudRate(SLUSBXpressDLL.hUSBDevice, 38400);

            // 2 Stopp bits, no parity, 8 data bits
            SLUSBXpressDLL.SI_SetLineControl(SLUSBXpressDLL.hUSBDevice, (2) + (8 << 8));
            
        }
        private void SendBytes(Byte[] arr)
        {
            int BytesSucceed = 0;
            SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Write(SLUSBXpressDLL.hUSBDevice,
                ref arr[0], arr.Length, ref BytesSucceed, 0);

            if ((BytesSucceed != arr.Length) || (SLUSBXpressDLL.Status != SLUSBXpressDLL.SI_SUCCESS))
            {
                MessageBox.Show("Error writing to USB. Wrote " + BytesSucceed.ToString() + " of " + arr.Length.ToString() + " bytes. Application is aborting. Reset hardware and try again.");
                Application.Exit();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Close(SLUSBXpressDLL.hUSBDevice);
            Application.Exit();    // Exit program
        }

        private void saveSettings(LEDText t, char action, char writeToEEPROM)
        {
            Byte[] arr = new Byte[2];
            arr[0] = 3;     // Text ändern
            arr[1] = (Byte)(cbSaveTextInEEPROM.Checked ? 1 : 0);  // in EEPROM speichern?
            byte[] arrS=t.getByteArray();

            Array.Resize(ref arr, 2 + arrS.Length);
            Array.Copy(arrS, 0, arr, 2, arrS.Length);

            SendBytes(arr);
        }

        private void btnSaveTimeSettings_Click(object sender, EventArgs e)
        {
            LEDText t = new LEDText();
            t.ticks2Begin = (UInt16)numTimeTicks2Begin.Value;
            t.ticks2End = (UInt16)numTimeTicks2End.Value;
            t.ticksBetween = (char)numTimeTicksBetween.Value;
            t.ticksPerScroll = (UInt16)numTimeTicksPerScroll.Value;
            t.scrollSpeed = (byte)numTimeScrollSpeed.Value;
            t.charWidth = (byte)numTimeCharWidth.Value;
            t.charSpace = (byte)numTimeCharSpace.Value;
            t.repeat = (byte)((cbTimeRepeat.Checked) ? 1 : 0);

            saveSettings(t, (char)0, (char)(cbSaveTimeSettingsInEEPROM.Checked ? 1 : 0));
        }

        private void btnSaveTextSettings_Click(object sender, EventArgs e)
        {
            LEDText t = new LEDText();
            t.ticks2Begin = (UInt16)numTicks2Begin.Value;
            t.ticks2End = (UInt16)numTicks2End.Value;
            t.ticksBetween = (char)numTicksBetween.Value;
            t.ticksPerScroll = (UInt16)numTicksPerScroll.Value;
            t.scrollSpeed = (byte)numScrollSpeed.Value;
            t.charWidth = (byte)numCharWidth.Value;
            t.charSpace = (byte)numCharSpace.Value;
            t.repeat = (byte)((cbRepeat.Checked) ? 1 : 0);

            saveSettings(t, (char)1, (char)(cbSaveTextSettingsInEEPROM.Checked ? 1 : 0));
        }

        private void btnSaveText_Click(object sender, EventArgs e)
        {
            Byte[] arr = new Byte[257];
            arr[0] = 3;     // Text ändern
            arr[1] = (Byte)(cbSaveTextInEEPROM.Checked ? 1 : 0);  // in EEPROM speichern?

            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            Byte[] arrText = encoding.GetBytes(tbLEDText.Text + '\0');
            Array.Copy(arrText, 0, arr, 2, Math.Min(arrText.Length, 255));
            arr[256] = 0;

            SendBytes(arr);
        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            Byte[] arr = new Byte[7];
            arr[0] = 2; // Uhrzeit stellen
            arr[1] = 0; // in EEPROM speichern
            arr[2] = (Byte)now.Hour;
            arr[3] = (Byte)now.Minute;
            arr[4] = (Byte)now.Second;
            arr[5] = (Byte)(now.Millisecond & (0xff));
            arr[6] = (Byte)(now.Millisecond >> 8);

            SendBytes(arr);
        }


    }
}
