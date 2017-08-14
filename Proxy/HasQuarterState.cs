using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class HasQuarterState : IState
    {
        GumballMachine gumballMachine;
        Random randomWinner = new Random(DateTime.Now.Millisecond);

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Debug.WriteLine("You already inserted a quarter.");
        }

        public void ejectQuarter()
        {
            Debug.WriteLine("Here's your quarter back.");
            gumballMachine.setState(gumballMachine.getNoQuarterState());
        }

        public void turnCrank()
        {
            Debug.WriteLine("You turned...");
            int winner = randomWinner.Next(10);
            if (winner == 0 && gumballMachine.getCount() > 1)
            {
                gumballMachine.setState(gumballMachine.getWinnerState());
            }
            else
            {
                gumballMachine.setState(gumballMachine.getSoldState());
            }            
        }

        public void dispense()
        {
            Debug.WriteLine("No gumball dispensed.");
        }
    }
}
