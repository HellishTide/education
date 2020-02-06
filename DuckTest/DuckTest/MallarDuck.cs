using System;
using System.Collections.Generic;
using System.Text;

namespace DuckTest
{
    public class MallarDuck: Duck
    {
        public MallarDuck() 
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
