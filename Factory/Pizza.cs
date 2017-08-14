using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// The Factory pattern abstract product class.
    /// </summary>
    public abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;
        public List<string> toppings = new List<string>();

        // these methods are marked as virtual, may or may not be overridden by the subclasses inheriting from this class.
        public virtual void prepare()
        {
            Debug.WriteLine("Preparing: " + name);
            Debug.WriteLine("Tossing dough...");
            Debug.WriteLine("Adding sauce...");
            Debug.WriteLine("Adding toppings:");
            foreach (var t in toppings)
            {
                Debug.WriteLine("   " + t);
            }
        }

        public virtual void bake()
        {
            Debug.WriteLine("Baking...");
        }

        public virtual void cut()
        {
            Debug.WriteLine("Cutting...");
        }

        public virtual void box()
        {
            Debug.WriteLine("Boxing...");
        }
    }
}
