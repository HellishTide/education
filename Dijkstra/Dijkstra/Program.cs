using System;
using Dijkstra;
using System.Collections.Generic;
using System.Linq;

namespace Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            //DijkstraSearch dj = new DijkstraSearch();
            List<string> vertices = new List<string> { "start", "a", "b", "fin" };
            Dictionary<string, double> edges_cost = new Dictionary<string, double>();
            edges_cost.Add("a", 6);
            edges_cost.Add("b", 2);
            edges_cost.Add("fin", 1);

            Lookup<string, string> graph = vertices.ToLookup(v => v.SelectMany, edges_cost );

            //Dictionary<string, int> vertices = new Dictionary<string, int>();
            Dictionary<string, string> parents = new Dictionary<string, string>();
            Dictionary<string, double> costs = new Dictionary<string, double>();
            Dictionary<string, double> edges = new Dictionary<string, double>();

            double infinity = Double.PositiveInfinity;

            // fill vertices
            vertices.Add("a", 6);
            vertices.Add("b", 2);
            vertices.Add("fin", 1);

            // fill parents
            parents.Add("a", "start");
            parents.Add("b", "start");
            parents.Add("fin", "None");

            // fill costs
            costs.Add("a", 6);
            costs.Add("b", 2);
            costs.Add("fin", infinity);
            
            //dj.Graph.Add("start", vertices);
        }
    }
}
