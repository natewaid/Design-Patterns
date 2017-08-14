using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// The adapter class implements the interface of the type of object we are adapting to, the interface expected by the client.
    /// Here we are adapting to the IDuck interface, but we are returning a turkey object with its methods.
    /// The client expects a Duck object, but gets a Turkey object that looks like a duck.
    /// The adapter class is what does the translation from one interface to another.
    /// </summary>
    public class TurkeyAdapter : IDuck
    {
        ITurkey turkey;

        /// <summary>
        /// We pass in a turkey object in the contructor since that is what we are adapting to the IDuck interface.
        /// </summary>
        /// <param name="turkey"></param>
        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        /// <summary>
        /// Implement the quack method of the IDuck interface, but call the gobble method of the turkey object.
        /// </summary>
        public void quack()
        {
            turkey.gobble();
        }

        /// <summary>
        /// Implement the fly method of the IDuck interface, but call the fly method of the turkey object.
        /// We call the method 5 times to make up for the distance turkeys fly versus the distance ducks can fly,
        /// since turkeys fly much shorter distances.
        /// </summary>
        public void fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.fly();
            }
        }
    }
}
