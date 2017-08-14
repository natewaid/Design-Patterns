using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class GumballMonitor
    {
        GumballMachine machine;

        public GumballMonitor(GumballMachine machine)
        {
            this.machine = machine;
        }

        public void report()
        {
            Debug.WriteLine("Gumball machine: " + machine.getLocation());
            Debug.WriteLine("Gumball inventory: " + machine.getCount());
            Debug.WriteLine("Gumball state: " + machine.getState());
        }
    }
}
