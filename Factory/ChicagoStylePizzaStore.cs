using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// A creator class, inherits from the abstract creator class.
    /// </summary>
    public class ChicagoStylePizzaStore : PizzaStore
    {
        // override the methods of the abstract class
        protected override Pizza createPizza(string item)
        {
            if (item.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (item.Equals("pepperoni"))
            {
                return new PepperoniPizza();
            }
            else if (item.Equals("clam"))
            {
                return new ClamPizza();
            }
            else if (item.Equals("veggie"))
            {
                return new VeggiePizza();
            }
            else
            {
                return null;
            }
        }
    }
}
