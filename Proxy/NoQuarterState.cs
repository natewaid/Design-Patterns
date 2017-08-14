using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class NoQuarterState : IState
    {
        GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Debug.WriteLine("You inserted a quarter.");
            gumballMachine.setState(gumballMachine.getHasQuarterState());
        }

        public void ejectQuarter()
        {
            Debug.WriteLine("You have not inserted a quarter.");
        }

        public void turnCrank()
        {
            Debug.WriteLine("You turned, but there is no quarter.");
        }

        public void dispense()
        {
            Debug.WriteLine("You need to pay first.");
        }
    }
}
