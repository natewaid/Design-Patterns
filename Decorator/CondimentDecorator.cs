using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// The abstract decorator class
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
        // marked 'override' to override the inherited method from beverage
        // marked abstract so other decorator objects can override
        public abstract override string getDescription();
    }
}
