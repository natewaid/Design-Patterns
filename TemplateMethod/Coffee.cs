using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Coffee : Beverage
    {
        public override void brew()
        {
            Debug.WriteLine("Dripping coffee through filter.");
        }

        public override void addCondiments()
        {
            Debug.WriteLine("Adding sugar and milk.");
        }

        public override bool hooked()
        {
            return false;
        }
    }
}
