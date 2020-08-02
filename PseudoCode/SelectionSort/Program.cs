using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        public static int[] GetSelectionSortedArray(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                var small = arr[i];
                var index = 0;
                for (var j = i; j <= arr.Length-1; j++)
                {
                    if (small >= arr[j]) 
                    {
                        small = arr[j];
                        index = j;
                    }
                }
                var temp = arr[i];
                arr[i] = small;
                arr[index] = temp;
            }
            return arr;
        }
        static void Main(string[] args)
        {
            var arr = new int[] { 100, 56, 8, 21, 3, 0, 45, 8, 1, 150 };
            var sortedArray = GetSelectionSortedArray(arr);
        }
    }
}
