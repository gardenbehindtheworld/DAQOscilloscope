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
        // DAQ analog read setup
        private NationalInstruments.DAQmx.Task analogReadTask;
        private AnalogMultiChannelReader reader;

        // User-specified analog read settings
        private double minimumVoltage;
        private double maximumVoltage;
        private AITerminalConfiguration terminalConfig;

        // Data collection
        private double[,] data;

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

            //analogReadTask.AIChannels.CreateVoltageChannel()
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
                    minimumVoltage = -10.0;
                    maximumVoltage = 10.0;
                    break;
                case 1:
                    minimumVoltage = -5.0;
                    maximumVoltage = 5.0;
                    break;
                case 2:
                    minimumVoltage = -1.0;
                    maximumVoltage = 1.0;
                    break;
                default:
                    minimumVoltage = -0.2;
                    maximumVoltage = 0.2;
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
                    terminalConfig = AITerminalConfiguration.Nrse;
                    break;
                case 1:
                    terminalConfig = AITerminalConfiguration.Rse;
                    break;
                default:
                    terminalConfig = AITerminalConfiguration.Differential;
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

            // Set output values
            double acquisitionTime = CalcAcquisitionTime();
            int numChannels = CalcNumChannels();
            lblADRateNum.Text = CalcADRate().ToString();
            lblAcquisitionTimeNum.Text = String.Format("{0:0.00}", acquisitionTime);
        }

        private void BtnClearChart_Click(object sender, EventArgs e)
        {
            chOscilloscope.Series.Clear();
        }

        private void BtnAcquire_Click(object sender, EventArgs e)
        {
            if (CalcAcquisitionTime() > MAX_TIME)
            {
                MessageBox.Show($"Data acquisition time must be limited to {MAX_TIME} seconds.");
            }
            else if (CalcADRate() > MAX_AD_RATE)
            {
                MessageBox.Show($"A/D rate must be limited to {MAX_AD_RATE} S/s.");
            }
            else if (terminalConfig == AITerminalConfiguration.Differential &&
                (int)updHighChannel.Value + 1 > GetDaqChannels().Length / 2)
            {
                MessageBox.Show($"Only the first {GetDaqChannels().Length / 2} " +
                    $"channels may be selected in DIFF mode.");
            }
            else
            {
                analogReadTask = new NationalInstruments.DAQmx.Task();
                SetUserInputEnabled(false);
                chOscilloscope.Series.Clear();

                string[] channelArray = GetDaqChannels();

                if (channelArray.Length == 0)
                {
                    MessageBox.Show("There are no available input channels.");
                }
                else
                {
                    string[] selChannelArray = GetSelectedChannels();

                    foreach (string channel in selChannelArray)
                    {
                        try
                        {
                            /* Create a channel that uses the appropriate channel name,
                             * terminal config, and voltage range
                             */
                            analogReadTask.AIChannels.CreateVoltageChannel(
                                channel, "", this.terminalConfig,
                                this.minimumVoltage, this.maximumVoltage, AIVoltageUnits.Volts);
                        }
                        catch (DaqException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        /* Add a series to the chart for each channel added
                         */
                        chOscilloscope.Series.Add(channel);
                        chOscilloscope.Series[channel].ChartType =
                            System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    }

                    try
                    {
                        // Set up task and reader for data collection
                        analogReadTask.Timing.ConfigureSampleClock(
                            string.Empty, (double)updSampleRate.Value,
                            SampleClockActiveEdge.Falling, SampleQuantityMode.FiniteSamples);
                        analogReadTask.Timing.SamplesPerChannel = (int)updSamplesPerChannel.Value;
                        reader = new AnalogMultiChannelReader(analogReadTask.Stream);

                        // Data collection
                        IAsyncResult readerResult = reader.BeginReadMultiSample(
                            (int)updSamplesPerChannel.Value, new AsyncCallback(PlotData), null);
                        this.data = reader.EndReadMultiSample(readerResult);
                    }
                    catch (DaqException ex) { MessageBox.Show(ex.Message); }
                }

                analogReadTask?.Dispose();
                SetUserInputEnabled(true);
            }
        }

        private void PlotData(IAsyncResult _)
        {
            chOscilloscope.ChartAreas[0].AxisX.Title = "Time (s)";
            chOscilloscope.ChartAreas[0].AxisY.Title = "Voltage (V)";
            chOscilloscope.ChartAreas[0].AxisX.Minimum = 0;
            chOscilloscope.ChartAreas[0].AxisY.Minimum = minimumVoltage * 1.1;
            chOscilloscope.ChartAreas[0].AxisY.Maximum = maximumVoltage * 1.1;

            chOscilloscope.Titles.Clear();
            chOscilloscope.Titles.Add("Voltage vs Time");
            double[] times = GetTimeAxisValues();
            int i = 0;
            foreach (string channel in GetSelectedChannels())
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    chOscilloscope.Series[channel].Points.AddXY(times[j], data[i, j]);
                }
                i++;
            }
        }

        private double[] GetTimeAxisValues()
        {
            int dataLength = data.GetLength(1);
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
            btnAcquire.Enabled = enableDisable;
            btnClearChart.Enabled = enableDisable;
        }

        private void Frm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            analogReadTask?.Dispose();
        }
    }
}
