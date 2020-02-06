using System;
using System.Collections.Generic;
using System.Text;

namespace DuckTest
{
    public class ModelDuck: Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
