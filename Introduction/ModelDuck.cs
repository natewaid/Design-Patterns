using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyNoWay();
        }

        public override void display()
        {
            Debug.WriteLine("I'm a model duck.");
        }
    }
}
