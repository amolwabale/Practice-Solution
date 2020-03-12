using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceCreation
{
    class Program
    {
        //Note -
        //1. Static constructor must be parameterless
        static void Main(string[] args)
        {
            //Static class Instantiation
            ClassC.Print();

            var a = new ClassA();
            a.Add(1, 2);
            a.Sub(1, 2);

            //Constructor is static of ClassB, it is possible to create instance of this class 
            //where the constructor will be ony initialized once.
            //If the constructor is declared as private, it is not possible to create the instance
            //and not posible to inherit from it. It will thow compile time error, class is in accessible due to its protection level.
            var b = new ClassB();
            b.Add(1, 2);
            b.Sub(1, 2);

            ClassA aa = new ClassA();
            aa.Add(1, 2);
            aa.Sub(1, 2);

            ClassB bb = new ClassB();
            bb.Add(1, 2);
            bb.Sub(1, 2);

            //ClassB aaa = new ClassA(); // DOWN CASTING NOT ALLOWED
            //aaa.Add(1, 2);
            //aaa.Sub(1, 2);

            ClassA bbb = new ClassB();
            bbb.Add(1, 2);
            bbb.Sub(1, 2);
        }
    }
}
