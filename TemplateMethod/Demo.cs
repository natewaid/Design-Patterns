using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Demo
    {
        public static void Main()
        {
            var coffee = new Coffee();
            var tea = new Tea();

            Debug.WriteLine("Brewing coffee.");
            coffee.prepareRecipe();

            Debug.WriteLine("\nBrewing tea.");
            tea.prepareRecipe();
        }
    }
}
