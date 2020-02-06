using System;
using System.Collections.Generic;
using System.Text;

namespace DuckTest
{
    public class FlyRocketPowered: IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
