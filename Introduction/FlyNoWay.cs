using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Debug.WriteLine("I can't fly!");
        }
    }
}
