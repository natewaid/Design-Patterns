using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Tea : Beverage
    {
        public override void brew()
        {
            Debug.WriteLine("Steeping the tea.");
        }

        public override void addCondiments()
        {
            Debug.WriteLine("Adding Lemon.");
        }
    }
}
