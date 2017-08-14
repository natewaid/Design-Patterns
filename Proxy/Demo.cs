using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Demo
    {
        public static void Main()
        {
            GumballMachine gumballMachine = new GumballMachine("test", 5);
            GumballMonitor monitor = new GumballMonitor(gumballMachine);

            monitor.report();
            

        }
    }
}
