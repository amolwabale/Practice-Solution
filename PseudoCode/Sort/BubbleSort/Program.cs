using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        //35. Implement(bubble, insertion, selection, merge) sort.
        // 36. Implement quicksort.
        //40. Given an array of integers, count the number of inversions it has.An inversion occurs when two elements in the array are out of order.
        
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
