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
            private Dictionary<string, List<(string, int)>> pairs = null;

            public Graph()
            {
                pairs = new Dictionary<string, List<(string, int)>>();
            }

            public void AddEdge(string k, string v, int weight)
            {
                if (!pairs.ContainsKey(k))
                    pairs.Add(k, new List<(string, int)>());
                pairs[k].Add((v, weight));
            }

            public void PrintGraph()
            {
                foreach (var item in pairs.Values)
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

                while (queue.Count > 0)
                {
                    var dqueue = queue.Dequeue();
                    Console.WriteLine(dqueue);
                    if (pairs.ContainsKey(dqueue))
                    {
                        var neighbourLst = pairs[dqueue];
                        foreach (var (neighbour, weight) in neighbourLst)
                        {
                            if (!hs.Contains(neighbour))
                            {
                                queue.Enqueue(neighbour);
                                hs.Add(neighbour);
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
                    foreach (var (neighbour, weight) in pairs[start])
                    {
                        DFS(neighbour, visited);
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
                    foreach (var (neighbour, weight) in pairs[start])
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

            public Dictionary<string, int> Dijkstras(string start)
            {
                var distances = new Dictionary<string, int>();
                var pq = new SortedSet<(int, string)>();

                foreach (var item in pairs.Keys)
                {
                    distances[item] = int.MaxValue;

                    foreach(var(neighbour, distance) in pairs[item])
                    {
                        distances[neighbour] = int.MaxValue;
                    }
                }

                distances[start] = 0;
                pq.Add((0, start));

                while (pq.Count > 0)
                {
                    var currentItem = pq.Min();
                    pq.Remove(currentItem);

                    if (!pairs.ContainsKey(currentItem.Item2))
                        continue;

                    foreach (var (neighbour, weight) in pairs[currentItem.Item2])
                    {
                        var distance = distances[currentItem.Item2] + weight;

                        if (distances[neighbour] != int.MaxValue)
                            pq.Remove((distances[neighbour], neighbour));
                        if (distance < distances[neighbour])
                        {
                            distances[neighbour] = distance;
                            if (!pq.Contains((distance, neighbour)))
                                pq.Add((distance, neighbour));
                        }
                    }
                }
                return distances;
            }

        }



        static void Main(string[] args)
        {
            Graph gp = new Graph();
            gp.AddEdge("A", "B", 10);
            gp.AddEdge("A", "C", 1);
            gp.AddEdge("C", "D", 3);
            gp.AddEdge("D", "E", 4);
            gp.AddEdge("B", "F", 2);
            gp.AddEdge("D", "F", 1);
            gp.AddEdge("F", "E", 3);

            gp.BFS("A");

            HashSet<string> vis = new HashSet<string>();
            gp.DFS("A", vis);

            HashSet<string> visited = new HashSet<string>();
            HashSet<string> recStack = new HashSet<string>();
            var result = gp.HasCycle("A", visited, recStack);

            var distance = gp.Dijkstras("A");

        }
    }
}
