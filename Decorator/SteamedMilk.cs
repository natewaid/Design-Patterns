﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SteamedMilk : CondimentDecorator
    {
        Beverage beverage;

        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Steamed Milk";
        }

        public override double cost()
        {
            return .10 + beverage.cost();
        }
    }
}
