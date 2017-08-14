using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public Duck()
        {

        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void swim()
        {
            Debug.WriteLine("All ducks float, even decoys.");
        }

        public abstract void display();

        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
