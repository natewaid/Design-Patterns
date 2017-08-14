using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// Implement the IDuck interface.
    /// </summary>
    public class Duck : IDuck
    {
        public void quack()
        {
            Debug.WriteLine("Quack! Quack!");
        }

        public void fly()
        {
            Debug.WriteLine("I'm flying!");
        }
    }
}
