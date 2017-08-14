using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// A product class, inherits from the abstract product class
    /// </summary>
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            // initialize the public variables of the abstract class
            name = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Extra Thick crust dough";
            sauce = "Plum tomato sauce";
            toppings.Add("Shredded mozzarella cheese");
        }

        // override one of the virtual methods of the abstract product class
        public override void cut()
        {
            Debug.WriteLine("Cutting the Chicago style pizza...");
        }
    }
}
