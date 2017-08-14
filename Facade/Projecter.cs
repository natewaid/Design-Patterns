using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Projecter
    {
        public void on()
        {
            Debug.WriteLine("Projecter on.");
        }

        public void off()
        {
            Debug.WriteLine("Projecter off.");
        }

        public void tvMode()
        {
            Debug.WriteLine("Projecter tv mode.");
        }

        public void wideScreenMode()
        {
            Debug.WriteLine("Projector wide screen mode.");
        }
    }
}
