using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace bfs
{
    public class Bfs
    {
        public Dictionary<string, List<string>> DictionaryGraph { get; set; } = new Dictionary<string, List<string>>();
        public Queue<string> SearchQueue { get; set; } = new Queue<string>();
        private List<string> Searched { get; set; } = new List<string>();
        private readonly string target = "kent";

        public string Bfs_Search(string name)
        {
            if (DictionaryGraph.Count != 0)
                AddToQueue(name);
            else
                throw new ArgumentNullException();

            while (SearchQueue.Count != 0)
            {
                string person = SearchQueue.Dequeue();

                if (!Searched.Contains(person))
                    if (person == target)
                    {
                        return String.Format("Find {0}", person);
                    }
                    else
                    {
                        Searched.Add(person);
                        AddToQueue(person);
                    }   
            }
            return String.Format("Not found");
        }

        public void AddToQueue(string name)
        {
            if (DictionaryGraph.ContainsKey(name))
            {
                DictionaryGraph[name].ForEach(delegate (String element)
                {
                    SearchQueue.Enqueue(element);
                });
                return;
            }
        }
    }
}
