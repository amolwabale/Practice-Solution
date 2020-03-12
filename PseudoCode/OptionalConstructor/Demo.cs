using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Demo
    {
        public Demo(int a)
        {
            Console.WriteLine("constructor - 1 para");
        }

        public Demo(int a, int b = 0)
        {
            Console.WriteLine("constructor - 2 para, optional");
        }

        public void Bring()
        {

        }
    }
}
