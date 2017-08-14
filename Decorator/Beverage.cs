using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// The abstract component class
    /// </summary>
    public abstract class Beverage
    {
        // the default description
        public string description = "Unknown beverage";

        // marked virtual so it can be inherited and overridden by the decorator class
        public virtual string getDescription()
        {
            return description;
        }

        // marked abstract so it can be overridden by the decorator class
        public abstract double cost();
    }
}
