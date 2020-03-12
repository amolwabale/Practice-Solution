using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceCreation
{
    static class ClassC
    {
        static ClassC()
        {
            Console.WriteLine("Static class Initialized");
        }

        public static void Print()
        {
            Console.WriteLine("Static class print");
        }
        
    }
}
