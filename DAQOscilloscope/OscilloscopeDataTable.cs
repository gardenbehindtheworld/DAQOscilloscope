using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQOscilloscope
{
    internal class OscilloscopeDataTable
    {
        public int DataPointsPerChannel { get; set; }
        public string[] Channels { get; set; }
        public double[] Times { get; set; }
        public double[,] Data { get; set; }
        public DateTime DataStartDate { get; private set; }

        public OscilloscopeDataTable(string[] channels, double samplesPerChannel,
            double sampleRate, double[,] data, DateTime startDate)
        {
            this.Channels = channels;
            this.Data = data;
            this.DataStartDate = startDate;
            this.DataPointsPerChannel = data.GetLength(1);
            this.Times = new double[DataPointsPerChannel];

            for (int i = 0; i < DataPointsPerChannel; i++)
            {
                this.Times[i] = (double)(i + 1) * samplesPerChannel / sampleRate / DataPointsPerChannel;
            }
        }

        public OscilloscopeDataTable(string filename, out double minVoltage, out double maxVoltage)
        {
            int dataPoints = 0;
            minVoltage = 0;
            maxVoltage = 0;
            double[,] data = new double[0,0];
            List<double> times = new List<double>();
            List<string> channels = new List<string>();
            try
            {
                if (System.IO.File.Exists(filename))
                {
                    string l; // line of text

                    System.IO.StreamReader objReader = new System.IO.StreamReader(filename);

                    // Read header (4 lines)
                    for (int i = 1; i <= 4; i++)
                    {
                        l = objReader.ReadLine();
                        switch (i)
                        {
                            case 1: // Date
                                break;
                            case 2: // Time
                                break;
                            case 3: // # Data Points
                                string[] ls = l.Trim(',').Split(',');
                                int.TryParse(ls[1], out dataPoints);
                                break;
                            case 4: // Column headers
                                string[] columns = l.Trim(',').Split(',');
                                for (int j = 1; j < columns.Length; j++)
                                {
                                    channels.Add(columns[j]);
                                }
                                break;
                        }
                    }

                    // Read data points
                    if (dataPoints > 0)
                    {
                        data = new double[channels.Count, dataPoints];

                        // Add data points in each row to channels
                        for (int i = 0; i < dataPoints; i++)
                        {
                            double num;
                            string[] ls = objReader.ReadLine().Trim(',').Split(',');

                            // Add first data point (time of data point)
                            if (double.TryParse(ls[0], out num))
                            {
                                times.Add(num);
                            }

                            // Add rest of data points for each channel
                            for (int j = 1; j <= channels.Count; j++)
                            {
                                if (double.TryParse(ls[j], out num))
                                {
                                    data[j - 1, i] = num;
                                    if (num < minVoltage) minVoltage = num;
                                    if (num > maxVoltage) maxVoltage = num;
                                }
                            }

                        }

                        Debug.WriteLine(objReader.Peek());

                        // Close out if there is more data than specified
                        if (objReader.Peek() != -1)
                        {
                            objReader.Close();
                            throw new Exception("The file data is not valid.");
                        }
                    }

                    objReader.Close();
                }
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            this.DataPointsPerChannel = dataPoints;
            this.Channels = channels.ToArray();
            this.Times = times.ToArray();
            this.Data = data;
        }

        public void WriteFile(string filename, bool append)
        {
            try
            {
                System.IO.StreamWriter objWriter = new System.IO.StreamWriter(filename, append);

                // File header
                objWriter.WriteLine($"Date,{DataStartDate}");
                objWriter.WriteLine($"Time,{DataStartDate.TimeOfDay}");
                objWriter.WriteLine($"# Data Points,{DataPointsPerChannel}");

                // Column headers
                objWriter.Write("Elapsed Time,");
                for (int i = 0; i < Channels.Length; i++)
                {
                    objWriter.Write($"{Channels[i]},");
                }
                objWriter.Write("\r\n");

                // Write row of data
                for (int i = 0; i < DataPointsPerChannel; i++)
                {
                    objWriter.Write($"{Times[i]},");
                    // Write columns of data
                    for (int j = 0; j < Data.GetLength(0); j++)
                    {
                        objWriter.Write($"{Data[j, i]},");
                    }
                    objWriter.Write("\r\n");
                }

                objWriter.Close();
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
