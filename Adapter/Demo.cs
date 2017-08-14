using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// Demonstrate the adapter pattern.
    /// </summary>
    public class Demo
    {
        public static void Main()
        {
            // create a duck and a turkey
            var duck = new Duck();
            var turkey = new WildTurkey();            

            // test the turkey object, make it gobble and fly a short distance
            Debug.WriteLine("\nThe turkey says...");
            turkey.gobble();
            turkey.fly();

            // test the duck object, make it quack and fly
            Debug.WriteLine("\nThe duck says...");
            duck.quack();
            duck.fly();

            // create a turkey adapter, giving it a turkey object, but it makes it look like a duck.
            var turkeyAdapter = new TurkeyAdapter(turkey);

            // test the turkey adapter
            // call the testduck method which expects a duck object, but send it the adapter object, which is actually a turkey.
            Debug.WriteLine("\nThe turkey adapter says...");
            TestDuck(turkeyAdapter);

            // create a duck adapter
            var duckAdapter = new DuckAdapter(duck);

            Debug.WriteLine("\nThe duck adapter says...");
            TestTurkey(duckAdapter);
        }

        static void TestDuck(IDuck duck)
        {
            duck.quack();
            duck.fly();
        }

        static void TestTurkey(ITurkey turkey)
        {
            turkey.gobble();
            turkey.fly();
        }
    }
}
