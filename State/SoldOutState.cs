using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SoldOutState : IState
    {
        GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Debug.WriteLine("Sold out of gumballs!");
        }

        public void ejectQuarter()
        {
            Debug.WriteLine("You have not inserted a quarter!");
        }

        public void turnCrank()
        {
            Debug.WriteLine("Gumballs aren't free!");
        }

        public void dispense()
        {
            Debug.WriteLine("No gumballs to dispense!");
        }
    }
}
