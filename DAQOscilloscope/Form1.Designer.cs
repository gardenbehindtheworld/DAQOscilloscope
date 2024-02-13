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
            this.btnAcquire = new System.Windows.Forms.Button();
            this.btnClearChart = new System.Windows.Forms.Button();
            this.pnlDaqConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updSamplesPerChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updSampleRate)).BeginInit();
            this.pnlChannelRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updHighChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLowChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chOscilloscope)).BeginInit();
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
            this.pnlDaqConfig.Location = new System.Drawing.Point(15, 45);
            this.pnlDaqConfig.Name = "pnlDaqConfig";
            this.pnlDaqConfig.Size = new System.Drawing.Size(331, 312);
            this.pnlDaqConfig.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "S/s";
            // 
            // lblADRateNum
            // 
            this.lblADRateNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblADRateNum.Location = new System.Drawing.Point(190, 263);
            this.lblADRateNum.Name = "lblADRateNum";
            this.lblADRateNum.Size = new System.Drawing.Size(91, 23);
            this.lblADRateNum.TabIndex = 16;
            this.lblADRateNum.Text = "0";
            this.lblADRateNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblADRate
            // 
            this.lblADRate.AutoSize = true;
            this.lblADRate.Location = new System.Drawing.Point(187, 250);
            this.lblADRate.Name = "lblADRate";
            this.lblADRate.Size = new System.Drawing.Size(53, 13);
            this.lblADRate.TabIndex = 15;
            this.lblADRate.Text = "A/D Rate";
            // 
            // lblAcquisitionTimeUnit
            // 
            this.lblAcquisitionTimeUnit.AutoSize = true;
            this.lblAcquisitionTimeUnit.Location = new System.Drawing.Point(287, 209);
            this.lblAcquisitionTimeUnit.Name = "lblAcquisitionTimeUnit";
            this.lblAcquisitionTimeUnit.Size = new System.Drawing.Size(12, 13);
            this.lblAcquisitionTimeUnit.TabIndex = 14;
            this.lblAcquisitionTimeUnit.Text = "s";
            // 
            // lblAcquisitionTimeNum
            // 
            this.lblAcquisitionTimeNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAcquisitionTimeNum.Location = new System.Drawing.Point(190, 204);
            this.lblAcquisitionTimeNum.Name = "lblAcquisitionTimeNum";
            this.lblAcquisitionTimeNum.Size = new System.Drawing.Size(91, 23);
            this.lblAcquisitionTimeNum.TabIndex = 13;
            this.lblAcquisitionTimeNum.Text = "0";
            this.lblAcquisitionTimeNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAcquisitionTime
            // 
            this.lblAcquisitionTime.AutoSize = true;
            this.lblAcquisitionTime.Location = new System.Drawing.Point(187, 191);
            this.lblAcquisitionTime.Name = "lblAcquisitionTime";
            this.lblAcquisitionTime.Size = new System.Drawing.Size(84, 13);
            this.lblAcquisitionTime.TabIndex = 12;
            this.lblAcquisitionTime.Text = "Acquisition Time";
            // 
            // updSamplesPerChannel
            // 
            this.updSamplesPerChannel.Location = new System.Drawing.Point(190, 141);
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
            this.updSampleRate.Location = new System.Drawing.Point(190, 91);
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
            this.cboVoltageRange.Location = new System.Drawing.Point(190, 36);
            this.cboVoltageRange.Name = "cboVoltageRange";
            this.cboVoltageRange.Size = new System.Drawing.Size(121, 21);
            this.cboVoltageRange.TabIndex = 10;
            this.cboVoltageRange.SelectedIndexChanged += new System.EventHandler(this.CboVoltageRange_SelectedIndexChanged);
            // 
            // cboTerminalConfig
            // 
            this.cboTerminalConfig.FormattingEnabled = true;
            this.cboTerminalConfig.Location = new System.Drawing.Point(20, 91);
            this.cboTerminalConfig.Name = "cboTerminalConfig";
            this.cboTerminalConfig.Size = new System.Drawing.Size(121, 21);
            this.cboTerminalConfig.TabIndex = 9;
            this.cboTerminalConfig.SelectedIndexChanged += new System.EventHandler(this.CboTerminalConfig_SelectedIndexChanged);
            // 
            // cboDevice
            // 
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(19, 36);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(121, 21);
            this.cboDevice.TabIndex = 6;
            // 
            // lblVoltageRange
            // 
            this.lblVoltageRange.AutoSize = true;
            this.lblVoltageRange.Location = new System.Drawing.Point(187, 20);
            this.lblVoltageRange.Name = "lblVoltageRange";
            this.lblVoltageRange.Size = new System.Drawing.Size(78, 13);
            this.lblVoltageRange.TabIndex = 6;
            this.lblVoltageRange.Text = "Voltage Range";
            // 
            // lblSampleRate
            // 
            this.lblSampleRate.AutoSize = true;
            this.lblSampleRate.Location = new System.Drawing.Point(187, 75);
            this.lblSampleRate.Name = "lblSampleRate";
            this.lblSampleRate.Size = new System.Drawing.Size(110, 13);
            this.lblSampleRate.TabIndex = 7;
            this.lblSampleRate.Text = "Channel Sample Rate";
            // 
            // lblSamplesPerChannel
            // 
            this.lblSamplesPerChannel.AutoSize = true;
            this.lblSamplesPerChannel.Location = new System.Drawing.Point(187, 125);
            this.lblSamplesPerChannel.Name = "lblSamplesPerChannel";
            this.lblSamplesPerChannel.Size = new System.Drawing.Size(117, 13);
            this.lblSamplesPerChannel.TabIndex = 8;
            this.lblSamplesPerChannel.Text = "# Samples per Channel";
            // 
            // lblTerminalConfig
            // 
            this.lblTerminalConfig.AutoSize = true;
            this.lblTerminalConfig.Location = new System.Drawing.Point(16, 75);
            this.lblTerminalConfig.Name = "lblTerminalConfig";
            this.lblTerminalConfig.Size = new System.Drawing.Size(112, 13);
            this.lblTerminalConfig.TabIndex = 2;
            this.lblTerminalConfig.Text = "Terminal Configuration";
            // 
            // lblChannelRange
            // 
            this.lblChannelRange.AutoSize = true;
            this.lblChannelRange.Location = new System.Drawing.Point(16, 146);
            this.lblChannelRange.Name = "lblChannelRange";
            this.lblChannelRange.Size = new System.Drawing.Size(81, 13);
            this.lblChannelRange.TabIndex = 3;
            this.lblChannelRange.Text = "Channel Range";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(16, 20);
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
            this.pnlChannelRange.Location = new System.Drawing.Point(19, 162);
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
            this.lblDaqConfig.Location = new System.Drawing.Point(12, 29);
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
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.chOscilloscope.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.IsDockedInsideChartArea = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            this.chOscilloscope.Legends.Add(legend1);
            this.chOscilloscope.Location = new System.Drawing.Point(362, 13);
            this.chOscilloscope.Name = "chOscilloscope";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chOscilloscope.Series.Add(series1);
            this.chOscilloscope.Size = new System.Drawing.Size(528, 425);
            this.chOscilloscope.TabIndex = 19;
            // 
            // btnAcquire
            // 
            this.btnAcquire.Location = new System.Drawing.Point(15, 380);
            this.btnAcquire.Name = "btnAcquire";
            this.btnAcquire.Size = new System.Drawing.Size(179, 39);
            this.btnAcquire.TabIndex = 20;
            this.btnAcquire.Text = "Acquire";
            this.btnAcquire.UseVisualStyleBackColor = true;
            this.btnAcquire.Click += new System.EventHandler(this.BtnAcquire_Click);
            // 
            // btnClearChart
            // 
            this.btnClearChart.Location = new System.Drawing.Point(206, 380);
            this.btnClearChart.Name = "btnClearChart";
            this.btnClearChart.Size = new System.Drawing.Size(140, 39);
            this.btnClearChart.TabIndex = 21;
            this.btnClearChart.Text = "Clear Chart";
            this.btnClearChart.UseVisualStyleBackColor = true;
            this.btnClearChart.Click += new System.EventHandler(this.BtnClearChart_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.btnClearChart);
            this.Controls.Add(this.btnAcquire);
            this.Controls.Add(this.chOscilloscope);
            this.Controls.Add(this.lblDaqConfig);
            this.Controls.Add(this.pnlDaqConfig);
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
        private System.Windows.Forms.Button btnAcquire;
        private System.Windows.Forms.Button btnClearChart;
    }
}

