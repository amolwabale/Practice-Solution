using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LRUCache
{
    class Program
    {

        static void Main(string[] args)
        {
            CacheEngine<int, string> cache = new CacheEngine<int, string>();
            for (var i = 0; i < 10; i++)
            {
                cache.Add(i, "Vale_" + i);
            }

            cache.Add(11, "Vale_11");
            cache.Add(12, "Vale_12");
            cache.Add(11, "Vale_111");

            var data = cache.Get(2);


            var pq = new Stack<int>();

            

        }
    }
}
