using System;
using System.Collections.Generic;
using System.Text;

namespace DuckTest
{
    public class Quack: IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Quack");
        }
    }
}
