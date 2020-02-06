using System;
using System.Collections.Generic;
using System.Text;

namespace DuckTest
{
    public class MuteQuack: IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}
