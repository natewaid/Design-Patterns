using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// Implement the ITurkey interface.
    /// </summary>
    public class WildTurkey : ITurkey
    {
        public void gobble()
        {
            Debug.WriteLine("Gobble! Gobble!");
        }

        public void fly()
        {
            Debug.WriteLine("I'm flying a short distance!");
        }
    }
}
