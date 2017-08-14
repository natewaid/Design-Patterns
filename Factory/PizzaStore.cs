using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// The Factory pattern abstract creator class.
    /// </summary>
    public abstract class PizzaStore
    {
        // This method called by the creator classes to execute the methods of the object being created by the factory.
        public Pizza orderPizza(string type)
        {
            Pizza pizza;

            pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.box();
            pizza.cut();

            return pizza;
        }

        // This method will be overridden by the creator subclasses that inherit from this class.
        protected abstract Pizza createPizza(string type);
    }
}
