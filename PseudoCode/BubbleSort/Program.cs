using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        //time complexity = O(n^2)
        //space complexity - O(n)
        static int[] GetSortedArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++ )
            {
                for (int j = 0; j < (arr.Length-1); j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            var arr = new int[] { 100,56,8,21,3,0,45,8};
            var sortedArray = GetSortedArray(arr);
        }
    }
}
