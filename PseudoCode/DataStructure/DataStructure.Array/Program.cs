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
            int[] arr = new int[] { 1, 2, 30, 5, 6, 7 };
            var data = FindMissingNumberFromArray(arr);

            var largetNum = FindLargestNumberInArray(arr);

            RotateArray(arr, 2);
        }

        public static int FindLargestNumberInArray(int[] arr)
        {
           

            var largestNumber = 0;
            for(var i= 0; i< arr.Length; i++)
            {
                if (largestNumber < arr[i])
                    largestNumber = arr[i];
            }
            return largestNumber;
        }

        public static void RotateArray(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n; // Handle if k > n
            if (k == 0) return;

            // Step 1: Reverse entire array
            Reverse(nums, 0, n - 1);

            // Step 2: Reverse first k elements
            Reverse(nums, 0, k - 1);

            // Step 3: Reverse the remaining n-k elements
            Reverse(nums, k, n - 1);
        }

        void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
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
