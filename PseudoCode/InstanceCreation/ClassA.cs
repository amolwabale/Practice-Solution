using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceCreation
{
    class ClassA
    {
        public virtual void Add(int a,int b)
        {
            Console.WriteLine("Class A - Add");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("Class A - Sub");
        }
    }
}
