using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Debug.WriteLine("My quack is wak!");
        }
    }
}
