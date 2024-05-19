using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubArraySumofK
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] {1, 2, 3, 4,1, 5 };
            var k = 5;

            Dictionary<int, int> count = new Dictionary<int, int>();
            count.Add(0, 1);
            var ans = 0;
            var sum = 0;
            foreach(var item in arr)
            {
                sum += item;
                if (count.ContainsKey(sum - k))
                {
                    ans += count[sum - k];
                }
                if (count.ContainsKey(sum))
                {
                    count[sum] = count[sum] + 1;
                }
                else
                {
                    count.Add(sum, 1);
                }
                
            }


        }
    }
}
