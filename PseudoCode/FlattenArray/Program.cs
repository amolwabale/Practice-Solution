using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenArray
{
    class Program
    {
        static int[] FlattenArray(int[][] arr)
        {
            var counter = 0;
            int[] newArr = new int[arr.Length * arr.GetUpperBound(0)];
            foreach(var item in arr)
            {
                newArr[counter] = item[0];
                counter++;
                newArr[counter] = item[1];
                counter++;
            }
            return newArr;
        }
        static void Main(string[] args)
        {
            var values = new[]
                {
                    new[] { 1, 2 },
                    new[] { 2, 3 },
                    new[] { 4, 5 },
                };
            FlattenArray(values);
        }
    }
}
