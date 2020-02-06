using System;

namespace DuckTest
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallarDuck();
            mallard.PerformQuack();
            mallard.PerformFly();
            Console.WriteLine("=============");

            Duck model = new ModelDuck();
            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();
            Console.WriteLine("=============");

            DuckDecoy duckDecoy = new DuckDecoy();
            duckDecoy.PerformFly();
            duckDecoy.PerformQuack();
            Console.WriteLine("=============");

        }
    }
}
