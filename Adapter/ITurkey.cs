using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// Simple interface, but different from IDuck.
    /// Turkeys do not quack, they gobble, so we have a gobble method instead.
    /// Turkeys can fly, but only short distances.
    /// </summary>
    public interface ITurkey
    {
        void gobble();

        void fly();
    }
}
