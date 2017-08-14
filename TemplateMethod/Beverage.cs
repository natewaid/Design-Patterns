using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    /// <summary>
    /// The super class has all the commonalities for the subclasses.
    /// </summary>
    public abstract class Beverage
    {        
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            addCondiments();
            if (hooked())
            {
                Debug.WriteLine("I'm hooked.");
            }
        }

        // abstract so that it can be implemented in the subclass
        public abstract void brew();

        public abstract void addCondiments();

        // only used by this class
        void boilWater()
        {
            Debug.WriteLine("Boiling water.");
        }

        void pourInCup()
        {
            Debug.WriteLine("Pouring in cup.");
        }

        // hook methods can be overridden in the subclasses, but do not have to be.  For this example, coffee overrides, tea does not.
        // if not overridden, the hook method performs some default behavior.
        public virtual bool hooked()
        {
            return true;
        }
    }
}
