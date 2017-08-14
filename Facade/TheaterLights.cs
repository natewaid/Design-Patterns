using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class TheaterLights
    {
        public void on()
        {
            Debug.WriteLine("Lights on.");
        }

        public void off()
        {
            Debug.WriteLine("Lights off.");
        }

        public void dim(int setting)
        {
            Debug.WriteLine("Lights dim " + setting + ".");
        }
    }
}
