using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceCreation
{
    class ClassB : ClassA
    {
        static ClassB()
        {
            Console.WriteLine("Class B - Static Constructor");
        }
        public override void Add(int a, int b)
        {
            Console.WriteLine("Class B - Add");
        }

        public new void Sub(int a, int b)
        {
            Console.WriteLine("Class B - Sub");
        }
    }
}
