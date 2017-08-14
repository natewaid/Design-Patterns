using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Tuner
    {
        public void on()
        {
            Debug.WriteLine("Tuner on.");
        }

        public void off()
        {
            Debug.WriteLine("Tuner off.");
        }

        public void setAm()
        {
            Debug.WriteLine("Tuner AM set.");
        }

        public void setFm()
        {
            Debug.WriteLine("Tuner FM set.");
        }

        public void setFrequency()
        {
            Debug.WriteLine("Tuner frequency set.");
        }
    }
}
