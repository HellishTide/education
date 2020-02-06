using System;
using System.Collections.Generic;
using System.Text;

namespace DuckTest
{
    public class FlyNoWay: IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
