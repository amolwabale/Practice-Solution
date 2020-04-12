using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static int[] GetSortedArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++ )
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
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
