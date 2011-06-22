namespace LEDPendelUhr
{
    partial class MainDlg
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.tbLEDText = new System.Windows.Forms.TextBox();
            this.btnSaveText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRepeat = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numCharSpace = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numCharWidth = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numScrollSpeed = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numTicksPerScroll = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numTicksBetween = new System.Windows.Forms.NumericUpDown();
            this.numTicks2End = new System.Windows.Forms.NumericUpDown();
            this.numTicks2Begin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabText = new System.Windows.Forms.TabPage();
            this.cbSaveTextSettingsInEEPROM = new System.Windows.Forms.CheckBox();
            this.cbSaveTextInEEPROM = new System.Windows.Forms.CheckBox();
            this.btnSaveTextSettings = new System.Windows.Forms.Button();
            this.tabTime = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.cbSaveTimeSettingsInEEPROM = new System.Windows.Forms.CheckBox();
            this.btnSaveTimeSettings = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTimeRepeat = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numTimeCharSpace = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numTimeCharWidth = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numTimeScrollSpeed = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numTimeTicksPerScroll = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numTimeTicksBetween = new System.Windows.Forms.NumericUpDown();
            this.numTimeTicks2End = new System.Windows.Forms.NumericUpDown();
            this.numTimeTicks2Begin = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCharSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCharWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScrollSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTicksPerScroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTicksBetween)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTicks2End)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTicks2Begin)).BeginInit();
            this.tabs.SuspendLayout();
            this.tabText.SuspendLayout();
            this.tabTime.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeCharSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeCharWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeScrollSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeTicksPerScroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeTicksBetween)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeTicks2End)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeTicks2Begin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(212, 378);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbLEDText
            // 
            this.tbLEDText.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLEDText.Location = new System.Drawing.Point(9, 22);
            this.tbLEDText.Name = "tbLEDText";
            this.tbLEDText.Size = new System.Drawing.Size(260, 23);
            this.tbLEDText.TabIndex = 1;
            this.tbLEDText.Text = "Hier kommt Dein Text rein...";
            // 
            // btnSaveText
            // 
            this.btnSaveText.Location = new System.Drawing.Point(194, 51);
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(75, 23);
            this.btnSaveText.TabIndex = 2;
            this.btnSaveText.Text = "Text ändern";
            this.btnSaveText.UseVisualStyleBackColor = true;
            this.btnSaveText.Click += new System.EventHandler(this.btnSaveText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anzeigetext:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pause vor erstem Zeichen (ticks):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSaveTextSettingsInEEPROM);
            this.groupBox1.Controls.Add(this.cbRepeat);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSaveTextSettings);
            this.groupBox1.Controls.Add(this.numCharSpace);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numCharWidth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numScrollSpeed);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numTicksPerScroll);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numTicksBetween);
            this.groupBox1.Controls.Add(this.numTicks2End);
            this.groupBox1.Controls.Add(this.numTicks2Begin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 249);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Einstellungen";
            // 
            // cbRepeat
            // 
            this.cbRepeat.AutoSize = true;
            this.cbRepeat.Checked = true;
            this.cbRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRepeat.Location = new System.Drawing.Point(188, 200);
            this.cbRepeat.Name = "cbRepeat";
            this.cbRepeat.Size = new System.Drawing.Size(15, 14);
            this.cbRepeat.TabIndex = 17;
            this.cbRepeat.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Endlosband:";
            // 
            // numCharSpace
            // 
            this.numCharSpace.Location = new System.Drawing.Point(188, 174);
            this.numCharSpace.Name = "numCharSpace";
            this.numCharSpace.Size = new System.Drawing.Size(62, 20);
            this.numCharSpace.TabIndex = 15;
            this.numCharSpace.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Zeichenabstand (ticks):";
            // 
            // numCharWidth
            // 
            this.numCharWidth.Location = new System.Drawing.Point(188, 148);
            this.numCharWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCharWidth.Name = "numCharWidth";
            this.numCharWidth.Size = new System.Drawing.Size(62, 20);
            this.numCharWidth.TabIndex = 13;
            this.numCharWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Zeichenbreite (Spalten):";
            // 
            // numScrollSpeed
            // 
            this.numScrollSpeed.Location = new System.Drawing.Point(188, 122);
            this.numScrollSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numScrollSpeed.Name = "numScrollSpeed";
            this.numScrollSpeed.Size = new System.Drawing.Size(62, 20);
            this.numScrollSpeed.TabIndex = 11;
            this.numScrollSpeed.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Scroll-Schritte (Spalten):";
            // 
            // numTicksPerScroll
            // 
            this.numTicksPerScroll.Location = new System.Drawing.Point(188, 96);
            this.numTicksPerScroll.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numTicksPerScroll.Name = "numTicksPerScroll";
            this.numTicksPerScroll.Size = new System.Drawing.Size(62, 20);
            this.numTicksPerScroll.TabIndex = 9;
            this.numTicksPerScroll.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Scroll-Pause (ticks):";
            // 
            // numTicksBetween
            // 
            this.numTicksBetween.Location = new System.Drawing.Point(188, 70);
            this.numTicksBetween.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTicksBetween.Name = "numTicksBetween";
            this.numTicksBetween.Size = new System.Drawing.Size(62, 20);
            this.numTicksBetween.TabIndex = 7;
            this.numTicksBetween.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numTicks2End
            // 
            this.numTicks2End.Location = new System.Drawing.Point(188, 44);
            this.numTicks2End.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numTicks2End.Name = "numTicks2End";
            this.numTicks2End.Size = new System.Drawing.Size(62, 20);
            this.numTicks2End.TabIndex = 6;
            this.numTicks2End.Value = new decimal(new int[] {
            330,
            0,
            0,
            0});
            // 
            // numTicks2Begin
            // 
            this.numTicks2Begin.Location = new System.Drawing.Point(188, 19);
            this.numTicks2Begin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTicks2Begin.Name = "numTicks2Begin";
            this.numTicks2Begin.Size = new System.Drawing.Size(62, 20);
            this.numTicks2Begin.TabIndex = 5;
            this.numTicks2Begin.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Leuchtdauer (ticks):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Zeit bis Ende (ticks):";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabText);
            this.tabs.Controls.Add(this.tabTime);
            this.tabs.Location = new System.Drawing.Point(3, 2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(288, 370);
            this.tabs.TabIndex = 5;
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.cbSaveTextInEEPROM);
            this.tabText.Controls.Add(this.btnSaveText);
            this.tabText.Controls.Add(this.label1);
            this.tabText.Controls.Add(this.tbLEDText);
            this.tabText.Controls.Add(this.groupBox1);
            this.tabText.Location = new System.Drawing.Point(4, 22);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(3);
            this.tabText.Size = new System.Drawing.Size(280, 344);
            this.tabText.TabIndex = 0;
            this.tabText.Text = "Anzeigetext";
            this.tabText.UseVisualStyleBackColor = true;
            // 
            // cbSaveTextSettingsInEEPROM
            // 
            this.cbSaveTextSettingsInEEPROM.AutoSize = true;
            this.cbSaveTextSettingsInEEPROM.Location = new System.Drawing.Point(9, 224);
            this.cbSaveTextSettingsInEEPROM.Name = "cbSaveTextSettingsInEEPROM";
            this.cbSaveTextSettingsInEEPROM.Size = new System.Drawing.Size(132, 17);
            this.cbSaveTextSettingsInEEPROM.TabIndex = 19;
            this.cbSaveTextSettingsInEEPROM.Text = "in EEPROM speichern";
            this.cbSaveTextSettingsInEEPROM.UseVisualStyleBackColor = true;
            // 
            // cbSaveTextInEEPROM
            // 
            this.cbSaveTextInEEPROM.AutoSize = true;
            this.cbSaveTextInEEPROM.Location = new System.Drawing.Point(18, 56);
            this.cbSaveTextInEEPROM.Name = "cbSaveTextInEEPROM";
            this.cbSaveTextInEEPROM.Size = new System.Drawing.Size(132, 17);
            this.cbSaveTextInEEPROM.TabIndex = 18;
            this.cbSaveTextInEEPROM.Text = "in EEPROM speichern";
            this.cbSaveTextInEEPROM.UseVisualStyleBackColor = true;
            // 
            // btnSaveTextSettings
            // 
            this.btnSaveTextSettings.Location = new System.Drawing.Point(175, 220);
            this.btnSaveTextSettings.Name = "btnSaveTextSettings";
            this.btnSaveTextSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTextSettings.TabIndex = 5;
            this.btnSaveTextSettings.Text = "speicherm";
            this.btnSaveTextSettings.UseVisualStyleBackColor = true;
            this.btnSaveTextSettings.Click += new System.EventHandler(this.btnSaveTextSettings_Click);
            // 
            // tabTime
            // 
            this.tabTime.Controls.Add(this.btnSetTime);
            this.tabTime.Controls.Add(this.label18);
            this.tabTime.Controls.Add(this.groupBox2);
            this.tabTime.Location = new System.Drawing.Point(4, 22);
            this.tabTime.Name = "tabTime";
            this.tabTime.Padding = new System.Windows.Forms.Padding(3);
            this.tabTime.Size = new System.Drawing.Size(280, 344);
            this.tabTime.TabIndex = 1;
            this.tabTime.Text = "Uhrzeit";
            this.tabTime.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(7, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(180, 25);
            this.label18.TabIndex = 23;
            this.label18.Text = "Uhrzeit-Anzeige";
            // 
            // cbSaveTimeSettingsInEEPROM
            // 
            this.cbSaveTimeSettingsInEEPROM.AutoSize = true;
            this.cbSaveTimeSettingsInEEPROM.Location = new System.Drawing.Point(9, 224);
            this.cbSaveTimeSettingsInEEPROM.Name = "cbSaveTimeSettingsInEEPROM";
            this.cbSaveTimeSettingsInEEPROM.Size = new System.Drawing.Size(132, 17);
            this.cbSaveTimeSettingsInEEPROM.TabIndex = 22;
            this.cbSaveTimeSettingsInEEPROM.Text = "in EEPROM speichern";
            this.cbSaveTimeSettingsInEEPROM.UseVisualStyleBackColor = true;
            // 
            // btnSaveTimeSettings
            // 
            this.btnSaveTimeSettings.Location = new System.Drawing.Point(175, 220);
            this.btnSaveTimeSettings.Name = "btnSaveTimeSettings";
            this.btnSaveTimeSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTimeSettings.TabIndex = 21;
            this.btnSaveTimeSettings.Text = "speichern";
            this.btnSaveTimeSettings.UseVisualStyleBackColor = true;
            this.btnSaveTimeSettings.Click += new System.EventHandler(this.btnSaveTimeSettings_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTimeRepeat);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbSaveTimeSettingsInEEPROM);
            this.groupBox2.Controls.Add(this.numTimeCharSpace);
            this.groupBox2.Controls.Add(this.btnSaveTimeSettings);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numTimeCharWidth);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.numTimeScrollSpeed);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.numTimeTicksPerScroll);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.numTimeTicksBetween);
            this.groupBox2.Controls.Add(this.numTimeTicks2End);
            this.groupBox2.Controls.Add(this.numTimeTicks2Begin);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(10, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 252);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Einstellungen";
            // 
            // cbTimeRepeat
            // 
            this.cbTimeRepeat.AutoSize = true;
            this.cbTimeRepeat.Location = new System.Drawing.Point(188, 200);
            this.cbTimeRepeat.Name = "cbTimeRepeat";
            this.cbTimeRepeat.Size = new System.Drawing.Size(15, 14);
            this.cbTimeRepeat.TabIndex = 17;
            this.cbTimeRepeat.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Endlosband:";
            // 
            // numTimeCharSpace
            // 
            this.numTimeCharSpace.Location = new System.Drawing.Point(188, 174);
            this.numTimeCharSpace.Name = "numTimeCharSpace";
            this.numTimeCharSpace.Size = new System.Drawing.Size(62, 20);
            this.numTimeCharSpace.TabIndex = 15;
            this.numTimeCharSpace.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Zeichenabstand (ticks):";
            // 
            // numTimeCharWidth
            // 
            this.numTimeCharWidth.Location = new System.Drawing.Point(188, 148);
            this.numTimeCharWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTimeCharWidth.Name = "numTimeCharWidth";
            this.numTimeCharWidth.Size = new System.Drawing.Size(62, 20);
            this.numTimeCharWidth.TabIndex = 13;
            this.numTimeCharWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Zeichenbreite (Spalten):";
            // 
            // numTimeScrollSpeed
            // 
            this.numTimeScrollSpeed.Location = new System.Drawing.Point(188, 122);
            this.numTimeScrollSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTimeScrollSpeed.Name = "numTimeScrollSpeed";
            this.numTimeScrollSpeed.Size = new System.Drawing.Size(62, 20);
            this.numTimeScrollSpeed.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Scroll-Schritte (Spalten):";
            // 
            // numTimeTicksPerScroll
            // 
            this.numTimeTicksPerScroll.Location = new System.Drawing.Point(188, 96);
            this.numTimeTicksPerScroll.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numTimeTicksPerScroll.Name = "numTimeTicksPerScroll";
            this.numTimeTicksPerScroll.Size = new System.Drawing.Size(62, 20);
            this.numTimeTicksPerScroll.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Scroll-Pause (ticks):";
            // 
            // numTimeTicksBetween
            // 
            this.numTimeTicksBetween.Location = new System.Drawing.Point(188, 70);
            this.numTimeTicksBetween.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTimeTicksBetween.Name = "numTimeTicksBetween";
            this.numTimeTicksBetween.Size = new System.Drawing.Size(62, 20);
            this.numTimeTicksBetween.TabIndex = 7;
            this.numTimeTicksBetween.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numTimeTicks2End
            // 
            this.numTimeTicks2End.Location = new System.Drawing.Point(188, 44);
            this.numTimeTicks2End.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numTimeTicks2End.Name = "numTimeTicks2End";
            this.numTimeTicks2End.Size = new System.Drawing.Size(62, 20);
            this.numTimeTicks2End.TabIndex = 6;
            this.numTimeTicks2End.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numTimeTicks2Begin
            // 
            this.numTimeTicks2Begin.Location = new System.Drawing.Point(188, 19);
            this.numTimeTicks2Begin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTimeTicks2Begin.Name = "numTimeTicks2Begin";
            this.numTimeTicks2Begin.Size = new System.Drawing.Size(62, 20);
            this.numTimeTicks2Begin.TabIndex = 5;
            this.numTimeTicks2Begin.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Leuchtdauer (ticks):";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Zeit bis Ende (ticks):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(165, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Pause vor erstem Zeichen (ticks):";
            // 
            // btnSetTime
            // 
            this.btnSetTime.Location = new System.Drawing.Point(185, 306);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(75, 23);
            this.btnSetTime.TabIndex = 24;
            this.btnSetTime.Text = "Uhr stellen";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // MainDlg
            // 
            this.AcceptButton = this.btnSaveText;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(294, 407);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.btnClose);
            this.Name = "MainDlg";
            this.Text = "LEDPendel-Uhr";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCharSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCharWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScrollSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTicksPerScroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTicksBetween)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTicks2End)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTicks2Begin)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tabText.ResumeLayout(false);
            this.tabText.PerformLayout();
            this.tabTime.ResumeLayout(false);
            this.tabTime.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeCharSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeCharWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeScrollSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeTicksPerScroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeTicksBetween)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeTicks2End)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeTicks2Begin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbLEDText;
        private System.Windows.Forms.Button btnSaveText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numTicks2Begin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTicks2End;
        private System.Windows.Forms.NumericUpDown numTicksBetween;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numScrollSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numTicksPerScroll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCharWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbRepeat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numCharSpace;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.TabPage tabTime;
        private System.Windows.Forms.Button btnSaveTextSettings;
        private System.Windows.Forms.CheckBox cbSaveTextSettingsInEEPROM;
        private System.Windows.Forms.CheckBox cbSaveTextInEEPROM;
        private System.Windows.Forms.CheckBox cbSaveTimeSettingsInEEPROM;
        private System.Windows.Forms.Button btnSaveTimeSettings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbTimeRepeat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numTimeCharSpace;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numTimeCharWidth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numTimeScrollSpeed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numTimeTicksPerScroll;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numTimeTicksBetween;
        private System.Windows.Forms.NumericUpDown numTimeTicks2End;
        private System.Windows.Forms.NumericUpDown numTimeTicks2Begin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSetTime;
    }
}

