using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Demo
    {
        public static void Main()
        {
            var nyStore = new NYStylePizzaStore();
            var chicagoStore = new ChicagoStylePizzaStore();

            var pizza = nyStore.orderPizza("cheese");
            Debug.WriteLine("NY Style cheese completed.\n");            

            pizza = chicagoStore.orderPizza("cheese");
            Debug.WriteLine("Chicago Style cheese completed.");
        }
    }
}
