using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GreedyAlgorithm
{
    public class Greedy
    {
        // sample data
        public HashSet<string> StatesNeeded { get; } = new HashSet<string> { "mt", "wa", "or", "id", "nv", "ut" };
        public Dictionary<string, HashSet<string>> Stations { get; } = new Dictionary<string, HashSet<string>>()
        {
             { "kone", new HashSet<string>{ "id", "nv", "ut" } }
            ,{ "kthree", new HashSet<string>{ "or", "nv", "ca" } }
            ,{ "ktwo", new HashSet<string>{ "wa", "id", "mt" } }
            ,{ "kfive", new HashSet<string>{ "ca", "az" } }
            ,{ "kfour", new HashSet<string>{ "nv", "ut" } }
        };

        public HashSet<string> FinalStations { get; set; } = new HashSet<string>();

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
    }
}
