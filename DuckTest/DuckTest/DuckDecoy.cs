using System;
using System.Collections.Generic;
using System.Text;

namespace DuckTest
{
    public class DuckDecoy
    {
        public IQuackBehavior QuackBehavior { get; set; }
        public IFlyBehavior FlyBehavior { get; set; }

        public DuckDecoy()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyNoWay();
        }

        public void Display()
        {
            Console.WriteLine("I'm a duck decoy");
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }
        
        public void PerformQuack()
        {
            QuackBehavior.DoQuack();
        }
    }
}
