using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void fly()
        {
            Debug.WriteLine("I'm flying with a rocket!");
        }
    }
}
