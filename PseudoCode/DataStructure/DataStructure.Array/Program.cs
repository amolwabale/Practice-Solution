using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            var eligibleIndex = TwoSum_Method1(arr, 11);
            arr = new int[] { 1, 2, 30, 5, 6, 7 };
            eligibleIndex = TwoSum_Method2(arr, 11);

            data = KadanesAlgorithm_MaxSubArraySum(arr);


            arr = new int[] { 2, 1, 5, 1, 3, 20 };
            var result = MaximumSumSubarrayofSizeK(arr, 3);
        }


        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to the target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //You can return the answer in any order.
        //Technique - Sliding Window
        //O(n^2)
        public static int[] TwoSum_Method1(int[] arr, int target)
        {
            var currentIndex = 0;
            var eligibleIndex = new int[2];
            var isFound = false;
            while (currentIndex <= arr.Length)
            {
                for (var i = currentIndex; i < arr.Length; i++)
                {
                    if (i != currentIndex)
                    {
                        var sum = arr[currentIndex] + arr[i];
                        if (sum == target)
                        {
                            eligibleIndex[0] = currentIndex;
                            eligibleIndex[1] = i;
                            isFound = true;
                            break;
                        }

                    }
                }
                currentIndex++;
                if (isFound == true)
                    break;
            }
            return eligibleIndex;
        }

        //O(n)
        public static int[] TwoSum_Method2(int[] arr, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];
                if (map.ContainsKey(complement))
                    return new int[] { map[complement], i };
                if (!map.ContainsKey(arr[i]))
                    map[arr[i]] = i;
            }
            return new int[] { };
        }


        //TimeComplexity - O(n), Space = O(1)
        //Use case - It is used to find out when you need to maximize something over continuous window.
        //e.g. - Audio signal processing to detect loudest segment
        //CPU Monitoring to detect spikes.
        //Mood Tracker - to detect longest positive peak.
        public static int KadanesAlgorithm_MaxSubArraySum(int[] arr)
        {

            var currentSum = arr[0];
            var MaxSum = arr[0];
            for(var i = 0; i< arr.Length; i++)
            {
                currentSum = Math.Max(arr[i], currentSum + arr[i]);
                MaxSum = Math.Max(MaxSum, currentSum);
            }
            return MaxSum;
        }

        //Maximum Sum Subarray of Size K
        //Given an array of integers arr[] and an integer k, find the maximum sum of a contiguous subarray of size k
        //arr = [2, 1, 5, 1, 3, 2], k = 3

        public static int MaximumSumSubarrayofSizeK(int[] arr, int k)
        {

            //BRUTE FORCE METHOD
            //var maxSum = 0;
            //for(var i=0; i <arr.Length; i++)
            //{
            //    var currentSum = 0;
            //    var limit = i + k;
            //    if (limit > arr.Length)
            //        return maxSum;
            //    for (var j = i;j < limit; j++)
            //    {
            //        currentSum += arr[j];
            //    }
            //    maxSum = Math.Max(maxSum, currentSum);
            //}
            //return maxSum;


            //SLIDING WINDOW METHOD.
            int maxSum = 0, windowSum = 0;

            // First window
            for (int i = 0; i < k; i++)
                windowSum += arr[i];

            maxSum = windowSum;

            // Slide the window
            for (int i = k; i < arr.Length; i++)
            {
                //**************IMPORTANT**************************
                windowSum += arr[i] - arr[i - k]; // Slide window forward
                maxSum = Math.Max(maxSum, windowSum);
            }

            return maxSum;
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

        static void Reverse(int[] arr, int start, int end)
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
