using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Demo
    {
        public static void Main()
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            Debug.WriteLine("Count: " + gumballMachine.getCount());

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();

            Debug.WriteLine("Count: " + gumballMachine.getCount());

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();

            Debug.WriteLine("Count: " + gumballMachine.getCount());

        }
    }
}
