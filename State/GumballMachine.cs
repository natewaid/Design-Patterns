using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class GumballMachine
    {
        IState soldOutState;
        IState noQuarterState;
        IState hasQuarterState;
        IState soldState;
        IState winnerState;

        IState state;
        int count = 0;

        public GumballMachine(int numberGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);

            state = soldOutState;
            count = numberGumballs;

            if (numberGumballs > 0)
            {
                state = noQuarterState;
            }
        }

        public void insertQuarter()
        {
            state.insertQuarter();
        }

        public void ejectQuarter()
        {
            state.ejectQuarter();
        }

        public void turnCrank()
        {
            state.turnCrank();
            state.dispense();
        }

        public void setState(IState state)
        {
            this.state = state;
        }

        public IState getNoQuarterState()
        {
            return noQuarterState;
        }

        public IState getHasQuarterState()
        {
            return hasQuarterState;
        }

        public IState getSoldOutState()
        {
            return soldOutState;
        }

        public IState getSoldState()
        {
            return soldState;
        }

        public IState getWinnerState()
        {
            return winnerState;
        }

        public IState getState()
        {
            return state;
        }

        public int getCount()
        {
            return count;
        }

        public void releaseGumball()
        {
            Debug.WriteLine("Here's your gumball.");
            if (count != 0)
            {
                count = count - 1;
            }
        }
    }
}
