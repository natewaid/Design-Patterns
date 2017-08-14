using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class DuckAdapter : ITurkey
    {
        IDuck duck;

        public DuckAdapter(IDuck duck)
        {
            this.duck = duck;
        }

        public void gobble()
        {
            duck.quack();
        }

        public void fly()
        {
            duck.fly();
        }
    }
}
