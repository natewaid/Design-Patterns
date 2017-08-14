using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// Simple interface with basic methods.
    /// Ducks quack and fly.
    /// </summary>
    public interface IDuck
    {
        void quack();

        void fly();
    }
}
