using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Binary
{
    class Program
    {
        static int FindNumber(int[] arr,int target)
        {
            
            var left = 0;
            var right = arr.Length - 1;
            while(left < right)
            {
                var mid = (left + right) / 2;
                if (arr[mid] == target)
                    return mid;
                if (target > arr[mid])
                    left = mid;
                else
                    right = mid;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            var a = FindNumber(arr, 9);
        }
    }
}
