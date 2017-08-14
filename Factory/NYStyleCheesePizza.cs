using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// A product class, inherits from the abstract product class
    /// </summary>
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            // initialize the public variables of the abstract class
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin crust dough";
            sauce = "Marinara sauce";
            toppings.Add("Grated reggiano cheese");
        }
    }
}
