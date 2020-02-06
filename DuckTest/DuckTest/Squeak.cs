using System;
using System.Collections.Generic;
using System.Text;

namespace DuckTest
{
    public class Squeak: IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
