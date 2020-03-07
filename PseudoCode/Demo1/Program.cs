using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {

            double factor = Math.Pow(0.5, 5);
            double truncated = Math.Floor(5 * factor) / factor;

            var demo = new Demo();
            demo.Bring();
            var demo1 = new Demo();
            demo1.Bring();
        }
    }
}
