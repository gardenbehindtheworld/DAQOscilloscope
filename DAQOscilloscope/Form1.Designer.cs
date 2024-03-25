namespace DAQOscilloscope
{
    partial class Frm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlDaqConfig = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblADRateNum = new System.Windows.Forms.Label();
            this.lblADRate = new System.Windows.Forms.Label();
            this.lblAcquisitionTimeUnit = new System.Windows.Forms.Label();
            this.lblAcquisitionTimeNum = new System.Windows.Forms.Label();
            this.lblAcquisitionTime = new System.Windows.Forms.Label();
            this.updSamplesPerChannel = new System.Windows.Forms.NumericUpDown();
            this.updSampleRate = new System.Windows.Forms.NumericUpDown();
            this.cboVoltageRange = new System.Windows.Forms.ComboBox();
            this.cboTerminalConfig = new System.Windows.Forms.ComboBox();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.lblVoltageRange = new System.Windows.Forms.Label();
            this.lblSampleRate = new System.Windows.Forms.Label();
            this.lblSamplesPerChannel = new System.Windows.Forms.Label();
            this.lblTerminalConfig = new System.Windows.Forms.Label();
            this.lblChannelRange = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.pnlChannelRange = new System.Windows.Forms.Panel();
            this.updHighChannel = new System.Windows.Forms.NumericUpDown();
            this.updLowChannel = new System.Windows.Forms.NumericUpDown();
            this.lblLowChannel = new System.Windows.Forms.Label();
            this.lblHighChannel = new System.Windows.Forms.Label();
            this.lblDaqConfig = new System.Windows.Forms.Label();
            this.chOscilloscope = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mnuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAppend = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcquire = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcquireBegin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChartClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdData = new System.Windows.Forms.SaveFileDialog();
            this.pnlDaqConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updSamplesPerChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updSampleRate)).BeginInit();
            this.pnlChannelRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updHighChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLowChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chOscilloscope)).BeginInit();
            this.mnuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDaqConfig
            // 
            this.pnlDaqConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDaqConfig.Controls.Add(this.label1);
            this.pnlDaqConfig.Controls.Add(this.lblADRateNum);
            this.pnlDaqConfig.Controls.Add(this.lblADRate);
            this.pnlDaqConfig.Controls.Add(this.lblAcquisitionTimeUnit);
            this.pnlDaqConfig.Controls.Add(this.lblAcquisitionTimeNum);
            this.pnlDaqConfig.Controls.Add(this.lblAcquisitionTime);
            this.pnlDaqConfig.Controls.Add(this.updSamplesPerChannel);
            this.pnlDaqConfig.Controls.Add(this.updSampleRate);
            this.pnlDaqConfig.Controls.Add(this.cboVoltageRange);
            this.pnlDaqConfig.Controls.Add(this.cboTerminalConfig);
            this.pnlDaqConfig.Controls.Add(this.cboDevice);
            this.pnlDaqConfig.Controls.Add(this.lblVoltageRange);
            this.pnlDaqConfig.Controls.Add(this.lblSampleRate);
            this.pnlDaqConfig.Controls.Add(this.lblSamplesPerChannel);
            this.pnlDaqConfig.Controls.Add(this.lblTerminalConfig);
            this.pnlDaqConfig.Controls.Add(this.lblChannelRange);
            this.pnlDaqConfig.Controls.Add(this.lblDevice);
            this.pnlDaqConfig.Controls.Add(this.pnlChannelRange);
            this.pnlDaqConfig.Location = new System.Drawing.Point(25, 62);
            this.pnlDaqConfig.Name = "pnlDaqConfig";
            this.pnlDaqConfig.Size = new System.Drawing.Size(331, 344);
            this.pnlDaqConfig.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "S/s";
            // 
            // lblADRateNum
            // 
            this.lblADRateNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblADRateNum.Location = new System.Drawing.Point(188, 272);
            this.lblADRateNum.Name = "lblADRateNum";
            this.lblADRateNum.Size = new System.Drawing.Size(91, 23);
            this.lblADRateNum.TabIndex = 16;
            this.lblADRateNum.Text = "0";
            this.lblADRateNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblADRate
            // 
            this.lblADRate.AutoSize = true;
            this.lblADRate.Location = new System.Drawing.Point(185, 259);
            this.lblADRate.Name = "lblADRate";
            this.lblADRate.Size = new System.Drawing.Size(53, 13);
            this.lblADRate.TabIndex = 15;
            this.lblADRate.Text = "A/D Rate";
            // 
            // lblAcquisitionTimeUnit
            // 
            this.lblAcquisitionTimeUnit.AutoSize = true;
            this.lblAcquisitionTimeUnit.Location = new System.Drawing.Point(285, 218);
            this.lblAcquisitionTimeUnit.Name = "lblAcquisitionTimeUnit";
            this.lblAcquisitionTimeUnit.Size = new System.Drawing.Size(12, 13);
            this.lblAcquisitionTimeUnit.TabIndex = 14;
            this.lblAcquisitionTimeUnit.Text = "s";
            // 
            // lblAcquisitionTimeNum
            // 
            this.lblAcquisitionTimeNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAcquisitionTimeNum.Location = new System.Drawing.Point(188, 213);
            this.lblAcquisitionTimeNum.Name = "lblAcquisitionTimeNum";
            this.lblAcquisitionTimeNum.Size = new System.Drawing.Size(91, 23);
            this.lblAcquisitionTimeNum.TabIndex = 13;
            this.lblAcquisitionTimeNum.Text = "0";
            this.lblAcquisitionTimeNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAcquisitionTime
            // 
            this.lblAcquisitionTime.AutoSize = true;
            this.lblAcquisitionTime.Location = new System.Drawing.Point(185, 200);
            this.lblAcquisitionTime.Name = "lblAcquisitionTime";
            this.lblAcquisitionTime.Size = new System.Drawing.Size(84, 13);
            this.lblAcquisitionTime.TabIndex = 12;
            this.lblAcquisitionTime.Text = "Acquisition Time";
            // 
            // updSamplesPerChannel
            // 
            this.updSamplesPerChannel.Location = new System.Drawing.Point(188, 150);
            this.updSamplesPerChannel.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.updSamplesPerChannel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updSamplesPerChannel.Name = "updSamplesPerChannel";
            this.updSamplesPerChannel.Size = new System.Drawing.Size(121, 20);
            this.updSamplesPerChannel.TabIndex = 11;
            this.updSamplesPerChannel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updSamplesPerChannel.ValueChanged += new System.EventHandler(this.UpdSamplesPerChannel_ValueChanged);
            // 
            // updSampleRate
            // 
            this.updSampleRate.Location = new System.Drawing.Point(188, 100);
            this.updSampleRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.updSampleRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updSampleRate.Name = "updSampleRate";
            this.updSampleRate.Size = new System.Drawing.Size(121, 20);
            this.updSampleRate.TabIndex = 8;
            this.updSampleRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updSampleRate.ValueChanged += new System.EventHandler(this.UpdSampleRate_ValueChanged);
            // 
            // cboVoltageRange
            // 
            this.cboVoltageRange.FormattingEnabled = true;
            this.cboVoltageRange.Location = new System.Drawing.Point(188, 45);
            this.cboVoltageRange.Name = "cboVoltageRange";
            this.cboVoltageRange.Size = new System.Drawing.Size(121, 21);
            this.cboVoltageRange.TabIndex = 10;
            this.cboVoltageRange.SelectedIndexChanged += new System.EventHandler(this.CboVoltageRange_SelectedIndexChanged);
            // 
            // cboTerminalConfig
            // 
            this.cboTerminalConfig.FormattingEnabled = true;
            this.cboTerminalConfig.Location = new System.Drawing.Point(18, 100);
            this.cboTerminalConfig.Name = "cboTerminalConfig";
            this.cboTerminalConfig.Size = new System.Drawing.Size(121, 21);
            this.cboTerminalConfig.TabIndex = 9;
            this.cboTerminalConfig.SelectedIndexChanged += new System.EventHandler(this.CboTerminalConfig_SelectedIndexChanged);
            // 
            // cboDevice
            // 
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(17, 45);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(121, 21);
            this.cboDevice.TabIndex = 6;
            // 
            // lblVoltageRange
            // 
            this.lblVoltageRange.AutoSize = true;
            this.lblVoltageRange.Location = new System.Drawing.Point(185, 29);
            this.lblVoltageRange.Name = "lblVoltageRange";
            this.lblVoltageRange.Size = new System.Drawing.Size(78, 13);
            this.lblVoltageRange.TabIndex = 6;
            this.lblVoltageRange.Text = "Voltage Range";
            // 
            // lblSampleRate
            // 
            this.lblSampleRate.AutoSize = true;
            this.lblSampleRate.Location = new System.Drawing.Point(185, 84);
            this.lblSampleRate.Name = "lblSampleRate";
            this.lblSampleRate.Size = new System.Drawing.Size(110, 13);
            this.lblSampleRate.TabIndex = 7;
            this.lblSampleRate.Text = "Channel Sample Rate";
            // 
            // lblSamplesPerChannel
            // 
            this.lblSamplesPerChannel.AutoSize = true;
            this.lblSamplesPerChannel.Location = new System.Drawing.Point(185, 134);
            this.lblSamplesPerChannel.Name = "lblSamplesPerChannel";
            this.lblSamplesPerChannel.Size = new System.Drawing.Size(117, 13);
            this.lblSamplesPerChannel.TabIndex = 8;
            this.lblSamplesPerChannel.Text = "# Samples per Channel";
            // 
            // lblTerminalConfig
            // 
            this.lblTerminalConfig.AutoSize = true;
            this.lblTerminalConfig.Location = new System.Drawing.Point(14, 84);
            this.lblTerminalConfig.Name = "lblTerminalConfig";
            this.lblTerminalConfig.Size = new System.Drawing.Size(112, 13);
            this.lblTerminalConfig.TabIndex = 2;
            this.lblTerminalConfig.Text = "Terminal Configuration";
            // 
            // lblChannelRange
            // 
            this.lblChannelRange.AutoSize = true;
            this.lblChannelRange.Location = new System.Drawing.Point(14, 155);
            this.lblChannelRange.Name = "lblChannelRange";
            this.lblChannelRange.Size = new System.Drawing.Size(81, 13);
            this.lblChannelRange.TabIndex = 3;
            this.lblChannelRange.Text = "Channel Range";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(14, 29);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(41, 13);
            this.lblDevice.TabIndex = 1;
            this.lblDevice.Text = "Device";
            // 
            // pnlChannelRange
            // 
            this.pnlChannelRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChannelRange.Controls.Add(this.updHighChannel);
            this.pnlChannelRange.Controls.Add(this.updLowChannel);
            this.pnlChannelRange.Controls.Add(this.lblLowChannel);
            this.pnlChannelRange.Controls.Add(this.lblHighChannel);
            this.pnlChannelRange.Location = new System.Drawing.Point(17, 171);
            this.pnlChannelRange.Name = "pnlChannelRange";
            this.pnlChannelRange.Size = new System.Drawing.Size(133, 124);
            this.pnlChannelRange.TabIndex = 1;
            // 
            // updHighChannel
            // 
            this.updHighChannel.Location = new System.Drawing.Point(11, 82);
            this.updHighChannel.Name = "updHighChannel";
            this.updHighChannel.Size = new System.Drawing.Size(110, 20);
            this.updHighChannel.TabIndex = 7;
            this.updHighChannel.ValueChanged += new System.EventHandler(this.UpdHighChannel_ValueChanged);
            // 
            // updLowChannel
            // 
            this.updLowChannel.Location = new System.Drawing.Point(11, 28);
            this.updLowChannel.Name = "updLowChannel";
            this.updLowChannel.Size = new System.Drawing.Size(110, 20);
            this.updLowChannel.TabIndex = 6;
            this.updLowChannel.ValueChanged += new System.EventHandler(this.UpdLowChannel_ValueChanged);
            // 
            // lblLowChannel
            // 
            this.lblLowChannel.AutoSize = true;
            this.lblLowChannel.Location = new System.Drawing.Point(8, 12);
            this.lblLowChannel.Name = "lblLowChannel";
            this.lblLowChannel.Size = new System.Drawing.Size(69, 13);
            this.lblLowChannel.TabIndex = 4;
            this.lblLowChannel.Text = "Low Channel";
            // 
            // lblHighChannel
            // 
            this.lblHighChannel.AutoSize = true;
            this.lblHighChannel.Location = new System.Drawing.Point(8, 66);
            this.lblHighChannel.Name = "lblHighChannel";
            this.lblHighChannel.Size = new System.Drawing.Size(71, 13);
            this.lblHighChannel.TabIndex = 5;
            this.lblHighChannel.Text = "High Channel";
            // 
            // lblDaqConfig
            // 
            this.lblDaqConfig.AutoSize = true;
            this.lblDaqConfig.Location = new System.Drawing.Point(22, 46);
            this.lblDaqConfig.Name = "lblDaqConfig";
            this.lblDaqConfig.Size = new System.Drawing.Size(95, 13);
            this.lblDaqConfig.TabIndex = 18;
            this.lblDaqConfig.Text = "DAQ Configuration";
            // 
            // chOscilloscope
            // 
            this.chOscilloscope.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chOscilloscope.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.chOscilloscope.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.IsDockedInsideChartArea = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            this.chOscilloscope.Legends.Add(legend1);
            this.chOscilloscope.Location = new System.Drawing.Point(362, 29);
            this.chOscilloscope.Name = "chOscilloscope";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chOscilloscope.Series.Add(series1);
            this.chOscilloscope.Size = new System.Drawing.Size(528, 409);
            this.chOscilloscope.TabIndex = 19;
            // 
            // mnuStrip1
            // 
            this.mnuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuAcquire,
            this.mnuChart,
            this.mnuHelp});
            this.mnuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mnuStrip1.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip1.Name = "mnuStrip1";
            this.mnuStrip1.Size = new System.Drawing.Size(902, 24);
            this.mnuStrip1.TabIndex = 22;
            this.mnuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.mnuFileSave,
            this.toolStripSeparator1,
            this.mnuFileQuit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuFileOpen.Text = "Open";
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileSaveNew,
            this.mnuFileSaveAppend});
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSave.Text = "Save";
            // 
            // mnuFileSaveNew
            // 
            this.mnuFileSaveNew.Name = "mnuFileSaveNew";
            this.mnuFileSaveNew.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSaveNew.Text = "New";
            this.mnuFileSaveNew.Click += new System.EventHandler(this.MnuFileSaveNew_Click);
            // 
            // mnuFileSaveAppend
            // 
            this.mnuFileSaveAppend.Name = "mnuFileSaveAppend";
            this.mnuFileSaveAppend.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSaveAppend.Text = "Append";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuFileQuit
            // 
            this.mnuFileQuit.Name = "mnuFileQuit";
            this.mnuFileQuit.Size = new System.Drawing.Size(180, 22);
            this.mnuFileQuit.Text = "Quit";
            // 
            // mnuAcquire
            // 
            this.mnuAcquire.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcquireBegin});
            this.mnuAcquire.Name = "mnuAcquire";
            this.mnuAcquire.Size = new System.Drawing.Size(60, 20);
            this.mnuAcquire.Text = "Acquire";
            // 
            // mnuAcquireBegin
            // 
            this.mnuAcquireBegin.Name = "mnuAcquireBegin";
            this.mnuAcquireBegin.Size = new System.Drawing.Size(165, 22);
            this.mnuAcquireBegin.Text = "Begin acquisition";
            this.mnuAcquireBegin.Click += new System.EventHandler(this.MnuAcquireBegin_Click);
            // 
            // mnuChart
            // 
            this.mnuChart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChartClear});
            this.mnuChart.Name = "mnuChart";
            this.mnuChart.Size = new System.Drawing.Size(48, 20);
            this.mnuChart.Text = "Chart";
            // 
            // mnuChartClear
            // 
            this.mnuChartClear.Name = "mnuChartClear";
            this.mnuChartClear.Size = new System.Drawing.Size(131, 22);
            this.mnuChartClear.Text = "Clear chart";
            this.mnuChartClear.Click += new System.EventHandler(this.MnuChartClear_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // sfdData
            // 
            this.sfdData.FileOk += new System.ComponentModel.CancelEventHandler(this.SfdData_FileOk);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.chOscilloscope);
            this.Controls.Add(this.lblDaqConfig);
            this.Controls.Add(this.pnlDaqConfig);
            this.Controls.Add(this.mnuStrip1);
            this.MinimumSize = new System.Drawing.Size(918, 489);
            this.Name = "Frm1";
            this.Text = "Oscilloscope";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm1_FormClosed);
            this.Load += new System.EventHandler(this.Frm1_Load);
            this.pnlDaqConfig.ResumeLayout(false);
            this.pnlDaqConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updSamplesPerChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updSampleRate)).EndInit();
            this.pnlChannelRange.ResumeLayout(false);
            this.pnlChannelRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updHighChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLowChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chOscilloscope)).EndInit();
            this.mnuStrip1.ResumeLayout(false);
            this.mnuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDaqConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblADRateNum;
        private System.Windows.Forms.Label lblADRate;
        private System.Windows.Forms.Label lblAcquisitionTimeUnit;
        private System.Windows.Forms.Label lblAcquisitionTimeNum;
        private System.Windows.Forms.Label lblAcquisitionTime;
        private System.Windows.Forms.NumericUpDown updSamplesPerChannel;
        private System.Windows.Forms.NumericUpDown updSampleRate;
        private System.Windows.Forms.ComboBox cboVoltageRange;
        private System.Windows.Forms.ComboBox cboTerminalConfig;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.Label lblVoltageRange;
        private System.Windows.Forms.Label lblSampleRate;
        private System.Windows.Forms.Label lblSamplesPerChannel;
        private System.Windows.Forms.Label lblTerminalConfig;
        private System.Windows.Forms.Label lblChannelRange;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Panel pnlChannelRange;
        private System.Windows.Forms.NumericUpDown updHighChannel;
        private System.Windows.Forms.NumericUpDown updLowChannel;
        private System.Windows.Forms.Label lblLowChannel;
        private System.Windows.Forms.Label lblHighChannel;
        private System.Windows.Forms.Label lblDaqConfig;
        private System.Windows.Forms.DataVisualization.Charting.Chart chOscilloscope;
        private System.Windows.Forms.MenuStrip mnuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuAcquire;
        private System.Windows.Forms.ToolStripMenuItem mnuChart;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAppend;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileQuit;
        private System.Windows.Forms.ToolStripMenuItem mnuAcquireBegin;
        private System.Windows.Forms.ToolStripMenuItem mnuChartClear;
        private System.Windows.Forms.SaveFileDialog sfdData;
    }
}

