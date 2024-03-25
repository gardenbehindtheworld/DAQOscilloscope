using NationalInstruments.DAQmx;
using NationalInstruments.Restricted;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQOscilloscope
{
    public partial class Frm1 : Form
    {
        private Oscilloscope osc;

        // DAQ board specs
        private const double MAX_TIME = 9.0; // seconds
        private const int MAX_AD_RATE = 250000; // samples/sec; from spec sheet
        private const int MAX_SAMPLES = 999999; // samples; unknown due to PC buffer

        public Frm1()
        {
            InitializeComponent();
        }

        private void Frm1_Load(object sender, EventArgs e)
        {
            osc = new Oscilloscope();

            // Start with an empty chart
            chOscilloscope.Series.Clear();

            // Set combo box styles
            cboDevice.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTerminalConfig.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVoltageRange.DropDownStyle = ComboBoxStyle.DropDownList;

            // Set up-down box min/max, then default value
            updHighChannel.Minimum = 0;
            updHighChannel.Value = 0;
            updLowChannel.Minimum = 0;
            updLowChannel.Value = 0;
            updSampleRate.Minimum = 1;
            updSampleRate.Maximum = MAX_AD_RATE;
            updSampleRate.Value = 1000;
            updSamplesPerChannel.Minimum = 1;
            updSamplesPerChannel.Maximum = MAX_SAMPLES;
            updSamplesPerChannel.Value = 1000;

            // Start outputs with values appropriate to input defaults
            NumericInputChanged();

            // Populate voltage range cbo
            cboVoltageRange.Items.AddRange(new string[]
            {
                "+/- 10V", "+/- 5V", "+/- 1V", "+/- 0.2V"
            });
            cboVoltageRange.SelectedIndex = 0;

            // Populate terminal config cbo
            cboTerminalConfig.Items.AddRange(new string[]
            {
                "NRSE", "RSE", "DIFF"
            });
            cboTerminalConfig.SelectedIndex = 0;

            // Get devices and populate device cbo
            cboDevice.Items.AddRange(DaqSystem.Local.Devices);
            if (cboDevice.Items.Count == 0)
            {
                SetUserInputEnabled(false);
                MessageBox.Show("No devices found.");
            }
            else
            {
                cboDevice.SelectedIndex = 0;
            }

            sfdData.Filter = "CSV File|*.csv|All Files|*.*";
        }

        private void UpdSampleRate_ValueChanged(object sender, EventArgs e)
        {
            NumericInputChanged();
        }

        private void UpdSamplesPerChannel_ValueChanged(object sender, EventArgs e)
        {
            NumericInputChanged();
        }

        private void UpdLowChannel_ValueChanged(object sender, EventArgs e)
        {
            NumericInputChanged();
        }

        private void UpdHighChannel_ValueChanged(object sender, EventArgs e)
        {
            NumericInputChanged();
        }

        private void CboVoltageRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboVoltageRange.SelectedIndex)
            {
                case 0:
                    osc.SetVoltageRange(-10.0, 10.0);
                    break;
                case 1:
                    osc.SetVoltageRange(-5.0, 5.0);
                    break;
                case 2:
                    osc.SetVoltageRange(-1.0, 1.0);
                    break;
                default:
                    osc.SetVoltageRange(-0.2, 0.2);
                    break;
            }
        }

        /* When the terminal config changes, update the property that is passed to
         * the analog reader
         */
        private void CboTerminalConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTerminalConfig.SelectedIndex)
            {
                case 0:
                    osc.TerminalConfig = AITerminalConfiguration.Nrse;
                    break;
                case 1:
                    osc.TerminalConfig = AITerminalConfiguration.Rse;
                    break;
                default:
                    osc.TerminalConfig = AITerminalConfiguration.Differential;
                    break;
            }
        }

        /* When the user changes any numeric inputs, update the output values
         * and other necessary settings
         */
        private void NumericInputChanged()
        {
            /* High Channel cannot be less than Low Channel,
            /* and Low Channel cannot be greater than High Channel
             */
            updLowChannel.Maximum = updHighChannel.Value;
            updHighChannel.Minimum = updLowChannel.Value;

            osc.SampleRate = (int)updSampleRate.Value;
            osc.SamplesPerChannel = (int)updSamplesPerChannel.Value;

            // Set output values
            double acquisitionTime = CalcAcquisitionTime();
            lblADRateNum.Text = CalcADRate().ToString();
            lblAcquisitionTimeNum.Text = String.Format("{0:0.00}", acquisitionTime);
        }

        private void MnuChartClear_Click(object sender, EventArgs e)
        {
            chOscilloscope.Series.Clear();
        }

        private void MnuAcquireBegin_Click(object sender, EventArgs e)
        {
            if (CalcAcquisitionTime() > MAX_TIME)
            {
                MessageBox.Show($"Data acquisition time must be limited to {MAX_TIME} seconds.");
            }
            else if (CalcADRate() > MAX_AD_RATE)
            {
                MessageBox.Show($"A/D rate must be limited to {MAX_AD_RATE} S/s.");
            }
            else if (osc.TerminalConfig == AITerminalConfiguration.Differential &&
                (int)updHighChannel.Value + 1 > GetDaqChannels().Length / 2)
            {
                MessageBox.Show($"Only the first {GetDaqChannels().Length / 2} " +
                    $"channels may be selected in DIFF mode.");
            }
            else
            {
                SetUserInputEnabled(false);
                osc.Acquire(GetDaqChannels(), GetSelectedChannels());
                chOscilloscope.Series.Clear();
                PlotData();
                SetUserInputEnabled(true);
            }
        }

        private void PlotData()
        {
            chOscilloscope.ChartAreas[0].AxisX.Title = "Time (s)";
            chOscilloscope.ChartAreas[0].AxisY.Title = "Voltage (V)";
            chOscilloscope.ChartAreas[0].AxisX.Minimum = 0;
            chOscilloscope.ChartAreas[0].AxisY.Minimum = osc.MinimumVoltage * 1.1;
            chOscilloscope.ChartAreas[0].AxisY.Maximum = osc.MaximumVoltage * 1.1;

            chOscilloscope.Titles.Clear();
            chOscilloscope.Titles.Add("Voltage vs Time");
            double[] times = GetTimeAxisValues();
            int i = 0;
            foreach (string channel in GetSelectedChannels())
            {
                /* Add a series to the chart for each channel added
                 */
                chOscilloscope.Series.Add(channel);
                chOscilloscope.Series[channel].ChartType =
                    System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int j = 0; j < osc.Data.GetLength(1); j++)
                {
                    chOscilloscope.Series[channel].Points.AddXY(times[j], osc.Data[i, j]);
                }
                i++;
            }
        }

        private double[] GetTimeAxisValues()
        {
            int dataLength = osc.Data.GetLength(1);
            double[] times = new double[dataLength];
            double stopTime = CalcAcquisitionTime();

            for (int i = 0; i < dataLength; i++)
            {
                times[i] = (double)(i+1) / dataLength * stopTime;
            }

            return times;
        }

        private double CalcAcquisitionTime()
        {
            return (double)updSamplesPerChannel.Value / (double)updSampleRate.Value;
        }

        private int CalcNumChannels()
        {
            return (int)updHighChannel.Value - (int)updLowChannel.Value + 1;
        }

        private int CalcADRate()
        {
            int numChannels = CalcNumChannels();
            return (int)updSampleRate.Value * numChannels;
        }

        private string[] GetDaqChannels()
        {
            string[] channelArray = DaqSystem.Local.GetPhysicalChannels(
                PhysicalChannelTypes.AI, PhysicalChannelAccess.External);
            updHighChannel.Maximum = channelArray.Length + 1;
            return channelArray;
        }

        private string[] GetSelectedChannels()
        {
            string[] channelArray = GetDaqChannels();
            int lowChannel = (int)updLowChannel.Value;
            int highChannel = (int)updHighChannel.Value;

            string[] selChannelArray = new string[highChannel - lowChannel + 1];
            for (int i = 0; i < selChannelArray.Length; i++)
            {
                selChannelArray[i] = channelArray[lowChannel + i];
            }

            return selChannelArray;
        }

        private void SetUserInputEnabled(bool enableDisable)
        {
            cboDevice.Enabled = enableDisable;
            /* Combo boxes don't become visibly enabled until moused over,
             * so we must also refresh them
             */
            cboDevice.Refresh();
            cboTerminalConfig.Enabled = enableDisable;
            cboTerminalConfig.Refresh();
            updLowChannel.Enabled = enableDisable;
            updHighChannel.Enabled = enableDisable;
            cboVoltageRange.Enabled = enableDisable;
            cboVoltageRange.Refresh();
            updSampleRate.Enabled = enableDisable;
            updSamplesPerChannel.Enabled = enableDisable;
        }

        private void Frm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            osc.DisposeTask();
        }

        private void MnuFileSaveNew_Click(object sender, EventArgs e)
        {
            sfdData.ShowDialog();
        }

        private void SfdData_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                System.IO.StreamWriter objWriter = new System.IO.StreamWriter(sfdData.FileName);

                // Write row of data
                for (int i = 0; i < osc.Data.GetLength(1); i++)
                {
                    objWriter.Write($"{(double)i / osc.SampleRate},");
                    // Write columns of data
                    for (int j = 0; j < osc.Data.GetLength(0); j++)
                    {
                        objWriter.Write($"{osc.Data[j, i]},");
                    }
                    objWriter.Write("\r\n");
                }

                objWriter.Close();
            }
            catch (System.IO.IOException ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
