using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Graphs
{
    class Program
    {

       public class Graph
        {
            private Dictionary<string, List<string>> pairs = null;

            public Graph()
            {
                pairs = new Dictionary<string, List<string>>();
            }

            public void AddEdge(string k, string v)
            {
                if (!pairs.ContainsKey(k))
                    pairs.Add(k, new List<string>());
                pairs[k].Add(v);
            }

            public void PrintGraph()
            {
                foreach(var item in pairs.Values)
                {
                    Console.WriteLine($"{item}");
                }
            }


            //Each node (vertex) is added to the queue once → O(V)
            //Each edge is looked at once(when traversing neighbors) → O(E)
            //TC = O(V+E)
            //SC = O(V)
            //Hack to remember - BFS is like exploring a building with an elevator — finish one floor, then move down.
            public void BFS(String start)
            {
                if (string.IsNullOrEmpty(start))
                    return;

                var queue = new Queue<string>();
                HashSet<string> hs = new HashSet<string>();
                queue.Enqueue(start);
                hs.Add(start);

                while(queue.Count > 0)
                {
                    var dqueue = queue.Dequeue();
                    Console.WriteLine(dqueue);
                    if (pairs.ContainsKey(dqueue))
                    {
                        var neighbour = pairs[dqueue];
                        foreach(var item in neighbour)
                        {
                            if (!hs.Contains(item))
                            {
                                queue.Enqueue(item);
                                hs.Add(item);
                            }

                        }
                    }
                }

            }

            //Each node (vertex) is added to the queue once → O(V)
            //Each edge is looked at once(when traversing neighbors) → O(E)
            //TC = O(V+E)
            //SC = O(V)
            //Hack to remember -  DFS is like exploring a cave with a torch — go deep before turning back.
            public void DFS(String start, HashSet<string> visited)
            {
                if (string.IsNullOrEmpty(start))
                    return;
                if (visited.Contains(start))
                    return;

                Console.WriteLine(start);
                visited.Add(start);

                if (pairs.ContainsKey(start))
                {
                    foreach (var item in pairs[start])
                    {
                        DFS(item, visited);
                    }
                }
            }

            //Each node (vertex) is added to the queue once → O(V)
            //Each edge is looked at once(when traversing neighbors) → O(E)
            //TC = O(V+E)
            //SC = O(V)
            //Hack to remember - Conference Call With Friends 
            //If someone calls back a friend who’s already on the same ongoing call, it’s a cycle!
            public bool HasCycle(string start, HashSet<string> visited, HashSet<string> recStack)
            {
                if (string.IsNullOrEmpty(start))
                    return false;

                visited.Add(start);
                recStack.Add(start);

                if (pairs.ContainsKey(start))
                {
                    foreach (var neighbour in pairs[start])
                    {
                        if (!visited.Contains(neighbour))
                        {
                            if (HasCycle(neighbour, visited, recStack))
                                return true;
                        }
                        else if (recStack.Contains(neighbour))
                            return true;

                    }
                }
                recStack.Remove(start);
                return false;
            }

        }

       

        static void Main(string[] args)
        {
            Graph gp = new Graph();
            gp.AddEdge("A", "B");
            gp.AddEdge("A", "C");
            gp.AddEdge("C", "D");
            gp.AddEdge("D", "E");

            gp.BFS("A");

            HashSet<string> vis = new HashSet<string>();
            gp.DFS("A", vis);

            HashSet<string> visited = new HashSet<string>();
            HashSet<string> recStack = new HashSet<string>();
            var result = gp.HasCycle("A", visited, recStack);

        }
    }
}
