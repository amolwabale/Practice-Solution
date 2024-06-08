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

        public class Edge
        {
            public int source;
            public int destination;

            public Edge(int s, int d)
            {
                this.source = s;
                this.destination = d;
            }
        }

        public static void CreateGraphUsingAdjacencyList(ArrayList[] arr)
        {
            for(var i = 0; i< arr.Length; i++)
            {
                arr[i] = new ArrayList();
            }
            arr[0].Add(new Edge(0, 1));
            arr[0].Add(new Edge(0, 2));

            arr[1].Add(new Edge(1, 0));
            arr[1].Add(new Edge(1, 3));

            arr[2].Add(new Edge(2, 0));
            arr[2].Add(new Edge(2, 4));

            arr[3].Add(new Edge(3, 1));
            arr[3].Add(new Edge(3, 4));
            arr[3].Add(new Edge(3, 5));

            arr[4].Add(new Edge(4, 2));
            arr[4].Add(new Edge(4, 3));
            arr[4].Add(new Edge(4, 5));

            arr[5].Add(new Edge(5, 3));
            arr[5].Add(new Edge(5, 4));
            arr[5].Add(new Edge(5, 6));

            arr[6].Add(new Edge(6, 5));

        }

        public static void bfs(ArrayList[] arr, int V)
        {
            Queue<int> q = new Queue<int>();
            bool[] visited = new bool[V];

            q.Enqueue(0);

            while(q.Count >0)
            {
                var curr = q.Dequeue();
                
                if(visited[curr] == false)
                {
                    visited[curr] = true;
                    Console.WriteLine(curr);
                    for(var i = 0; i<arr[curr].Count; i++)
                    {
                        var e = arr[curr][i] as Edge;
                        q.Enqueue(e.destination);
                    }
                }
            }
        }

        public static void brokenbfs(ArrayList[] arr, int V, bool[] visited, int start)
        {
            Queue<int> q = new Queue<int>();

            q.Enqueue(start);

            while (q.Count > 0)
            {
                var curr = q.Dequeue();

                if (visited[curr] == false)
                {
                    visited[curr] = true;
                    Console.WriteLine(curr);
                    for (var i = 0; i < arr[curr].Count; i++)
                    {
                        var e = arr[curr][i] as Edge;
                        q.Enqueue(e.destination);
                    }
                }
            }
        }

        public static void dfs(ArrayList[] arr, int curr, bool[] visited)
        {
            Console.WriteLine(curr);
            visited[curr] = true;

            for(var i = 0; i< arr[curr].Count; i++)
            {
                var edge = arr[curr][i] as Edge;
                if (visited[edge.destination] == false)
                    dfs(arr, edge.destination, visited);
            }
        }


        public static void PossiblePathBetSourceAndDest(ArrayList[] arr, int curr, bool[] visited, String path, int dest)
        { 
            if(curr == dest)
            {
                Console.WriteLine(path);
                return;
            }
            visited[curr] = true;
            for (var i = 0; i< arr[curr].Count; i++)
            {
                var edge = arr[curr][i] as Edge;
                if (visited[edge.destination] == false) {
                    
                    path += edge.destination + ", ";
                    PossiblePathBetSourceAndDest(arr, edge.destination, visited, path, dest);
                    
                }
            }
            visited[curr] = false;
        }


        static void Main(string[] args)
        {
            int V = 7;
            ArrayList[] arr = new ArrayList[V];
            CreateGraphUsingAdjacencyList(arr);

            Console.WriteLine("Breadth First Search");
            bfs(arr, V); //TC - O(V+E)

            Console.WriteLine("Breadth First Search - Broken Graph");
            bool[] visited = new bool[V];
            for(var i = 0; i < V; i++)
            {
                if(visited[i] == false)
                {
                    brokenbfs(arr, V, visited, i); //TC - O(V+E)
                }
            }

            Console.WriteLine("Depth First Search");
            visited = new bool[V];
            for (var i = 0; i < V; i++)
            {
                if (visited[i] == false)
                {
                    dfs(arr, i, visited); //TC - O(V+E)
                }
            }

            Console.WriteLine("Find all possible paths between source and target");
            visited = new bool[V];
            PossiblePathBetSourceAndDest(arr, 0, visited, "0, ", 5);



        }
    }
}
