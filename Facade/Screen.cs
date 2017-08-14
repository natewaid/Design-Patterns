using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Screen
    {
        public void up()
        {
            Debug.WriteLine("Screen up.");
        }

        public void down()
        {
            Debug.WriteLine("Screen down.");
        }
    }
}
