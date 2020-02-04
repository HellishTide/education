using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedyAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Greedy g = new Greedy();
            g.Find();
            foreach(var el in g.FinalStations)
                Console.WriteLine(el);

        }
    }
}
