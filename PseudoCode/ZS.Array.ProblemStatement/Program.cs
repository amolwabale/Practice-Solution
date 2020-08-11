using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZS.Array.ProblemStatement
{
    class Program
    {
        //Problem Statement
        //If there is two array
        //string[] Arr1 = { "mango", "apple", "grape", "fig" };
        //string[] Arr2 = { "pineapple", "pomegranate", "papaya", "apple" };
        //need all items from first array and from second array only those which is not present in first with less time complexity.

        static void Main(string[] args)
        {
            string[] Arr1 = { "mango", "apple", "grape", "fig", "apple" };
            string[] Arr2 = { "pineapple", "pomegranate", "papaya", "apple" };
            Evaluate(Arr1,Arr2);

            HashSet<string> obj = new HashSet<string>();
            foreach(var item in Arr1.Union(Arr2))
            {
                obj.Add(item);
            }
        }

        public static void Evaluate(string[] arr1, string[] arr2)
        {
            var a = arr1.Intersect(arr2).ToArray();
            var result = arr1.Concat(arr2.Except(a).ToArray());
            
        }
    }
}
