using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GreedyAlgorithm
{
    public class Greedy
    {
        // sample data
        private HashSet<string> StatesNeeded { get; } = new HashSet<string> { "mt", "wa", "or", "id", "nv", "ut", "ca", "az" };
        private Dictionary<string, HashSet<string>> Stations { get; } = new Dictionary<string, HashSet<string>>()
        {
             { "kone", new HashSet<string>{ "id", "nv", "ut" } }
            ,{ "ktwo", new HashSet<string>{ "wa", "id", "mt" } }
            ,{ "kthree", new HashSet<string>{ "or", "nv", "ca" } }
            ,{ "kfour", new HashSet<string>{ "nv", "ut" } }
            ,{ "kfive", new HashSet<string>{ "ca", "az" } }
        };

        private HashSet<string> FinalStations { get; set; } = new HashSet<string>();

        private HashSet<string> StatesCovered { get; set; } = new HashSet<string>();

        public void Find()
        {
            while (StatesNeeded.Count > 0)
            {
                string best_station = "";
                StatesCovered.Clear();

                foreach (var kvp in Stations)
                {
                    HashSet<string> covered = new HashSet<string>(StatesNeeded);
                    covered.IntersectWith(kvp.Value);

                    if (covered.Count > StatesCovered.Count)
                    {
                        best_station = kvp.Key;
                        StatesCovered = covered;
                    }
                }

                StatesNeeded.ExceptWith(StatesCovered);
                FinalStations.Add(best_station);
            }
        }

        public void PrintFoundedStationsToConsole()
        {
            foreach(var element in FinalStations)
                Console.WriteLine(element);
        }
    }
}
