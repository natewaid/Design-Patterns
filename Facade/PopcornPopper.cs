using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class PopcornPopper
    {
        public void on()
        {
            Debug.WriteLine("Popper on.");
        }

        public void off()
        {
            Debug.WriteLine("Popper off.");
        }

        public void pop()
        {
            Debug.WriteLine("Popper popping.");
        }
    }
}
