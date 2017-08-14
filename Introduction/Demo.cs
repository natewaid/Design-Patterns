using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    public class Demo
    {
        public static void Main()
        {
            var duck = new MallardDuck();

            duck.performQuack();
            duck.performFly();

            var model = new ModelDuck();
            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();

            

        }
    }
}
