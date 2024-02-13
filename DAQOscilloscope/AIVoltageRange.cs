using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQOscilloscope
{
    internal class AIVoltageRange
    {
        public double MinimumVoltage { get; set; }
        public double MaximumVoltage { get; set; }

        public AIVoltageRange(double voltage)
        {
            this.MinimumVoltage = -voltage;
            this.MaximumVoltage = voltage;
        }
        
        public override string ToString()
        {
            return String.Format("+/- {0}V", this.MaximumVoltage);
        }
    }
}
