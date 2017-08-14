using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// Interface used to display the elements.
    /// Required by the API, implement for all Observer concrete classes.
    /// </summary>
    public interface IDisplayElement
    {
        void display();
    }
}
