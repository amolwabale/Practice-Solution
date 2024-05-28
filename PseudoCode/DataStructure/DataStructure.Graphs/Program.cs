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
            public int weight;

            public Edge(int s, int d, int w)
            {
                this.source = s;
                this.destination = d;
                this.weight = w;
            }
        }

        public static void CreateGraphUsingAdjacencyList(ArrayList[] arr)
        {
            for(var i = 0; i< arr.Length; i++)
            {
                arr[i] = new ArrayList();
            }
            arr[0].Add(new Edge(0, 2, 2));

            arr[1].Add(new Edge(1, 2, 10));
            arr[1].Add(new Edge(1, 3, 0));

            arr[2].Add(new Edge(2, 0, 2));
            arr[2].Add(new Edge(2, 1, 10));
            arr[2].Add(new Edge(2, 3, -1));

            arr[3].Add(new Edge(3, 1, 0));
            arr[3].Add(new Edge(3, 2, -1));

        }

        static void Main(string[] args)
        {
            ArrayList[] arr = new ArrayList[4];
            CreateGraphUsingAdjacencyList(arr);
            for(var i = 0; i< arr.Length; i++)
            {
                for(var j = 0; j< arr[i].Count; j++)
                {
                    var obj = arr[i][j] as Edge;
                    Console.WriteLine(string.Format("Source: {0}, Destination:{1}", obj.source, obj.destination));
                }
            }


        }
    }
}
