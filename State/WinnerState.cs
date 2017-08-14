using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class WinnerState : IState
    {
        GumballMachine gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Debug.WriteLine("Please wait, we've already given you a gumball.");
        }

        public void ejectQuarter()
        {
            Debug.WriteLine("Sorry, you already turned the crank.");
        }

        public void turnCrank()
        {
            Debug.WriteLine("Turning twice doesn't give you another gumball.");
        }

        public void dispense()
        {
            Debug.WriteLine("You're a winner!  You get 2 gumballs for your quarter!");
            gumballMachine.releaseGumball();
            if (gumballMachine.getCount() == 0)
            {
                gumballMachine.setState(gumballMachine.getSoldOutState());
            }
            else
            {
                gumballMachine.releaseGumball();
                if (gumballMachine.getCount() > 0)
                {
                    gumballMachine.setState(gumballMachine.getNoQuarterState());
                }
                else
                {
                    Debug.WriteLine("Out of gumballs.");
                    gumballMachine.setState(gumballMachine.getSoldOutState());
                }
            }
        }
    }
}
