using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 5, 6, 7 };
            var data = FindMissingNumberFromArray(arr);
        }

        public static int FindMissingNumberFromArray(int[] arr)
        {
            var sum = 0;
            var arrSum = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                sum += i+1;
                arrSum += arr[i];
            }
            return Math.Abs(arrSum - sum);
        }
    }
}
