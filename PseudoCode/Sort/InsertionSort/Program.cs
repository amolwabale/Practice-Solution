using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        //It consist of two parts, left and right.
        //Left part consist of sub list which is sorted.
        //Where else right part is the existing list which is compared to form left list.
        //In Marathi, Magha sarkawaun insert karache madhe, manje insertion sort.
        static void sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        static void Main(string[] args)
        {
            var arr = new int[] { 100, 56, 8, 21, 3, 0, 45, 8, 1, 150 };
            sort(arr);
        }
    }
}
