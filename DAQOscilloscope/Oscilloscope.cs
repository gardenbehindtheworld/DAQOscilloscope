using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQOscilloscope
{
    internal class Oscilloscope
    {
        // DAQ analog read setup
        private NationalInstruments.DAQmx.Task analogReadTask;
        private AnalogMultiChannelReader reader;

        // User-specified analog read settings
        public double MinimumVoltage { get; private set; }
        public double MaximumVoltage { get; private set; }
        public AITerminalConfiguration TerminalConfig { get; set; }

        // Data collection
        public double[,] Data { get; private set; }
        public DateTime DataStartDate { get; private set; }
        public TimeSpan DataStartTime { get; private set; }
        public string[] DataChannels { get; private set; }

        public int SamplesPerChannel { get; set; }
        public int SampleRate { get; set; }

        public Oscilloscope()
        {

        }

        public double[,] Acquire(string[] channelArray, string[] selChannelArray)
        {
            analogReadTask = new NationalInstruments.DAQmx.Task();

            if (channelArray.Length == 0)
            {
                throw new Exception("There are no available input channels.");
            }
            else
            {
                DataChannels = selChannelArray;
                DataStartDate = DateTime.Now.Date;
                DataStartTime = DateTime.Now.TimeOfDay;

                foreach (string channel in selChannelArray)
                {
                    try
                    {
                        /* Create a channel that uses the appropriate channel name,
                         * terminal config, and voltage range
                         */
                        analogReadTask.AIChannels.CreateVoltageChannel(
                            channel, "", TerminalConfig,
                            MinimumVoltage, MaximumVoltage, AIVoltageUnits.Volts);
                    }
                    catch (DaqException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                try
                {
                    // Set up task and reader for data collection
                    analogReadTask.Timing.ConfigureSampleClock(
                        string.Empty, SampleRate,
                        SampleClockActiveEdge.Falling, SampleQuantityMode.FiniteSamples);
                    analogReadTask.Timing.SamplesPerChannel = SamplesPerChannel;
                    reader = new AnalogMultiChannelReader(analogReadTask.Stream);

                    // Data collection
                    IAsyncResult readerResult = reader.BeginReadMultiSample(
                        SamplesPerChannel, null, null);
                    Data = reader.EndReadMultiSample(readerResult);
                }
                catch (DaqException ex) { MessageBox.Show(ex.Message); }
            }
            this.DisposeTask();
            return Data;
        }

        public void SetVoltageRange(double min, double max)
        {
            MinimumVoltage = min;
            MaximumVoltage = max;
        }

        public void DisposeTask()
        {
            analogReadTask?.Dispose();
        }
    }
}
