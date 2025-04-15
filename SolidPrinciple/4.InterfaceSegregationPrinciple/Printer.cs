using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.InterfaceSegregationPrinciple
{
    public interface IPrinter
    {
        void Print();
    }
    public class ColourPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("ColourPrinter");
        }
    }

    public class BlackAndWhitePrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("BlackAndWhitePrinter");
        }
    }

    public class LaserPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("LaserPrinter");
        }
    }
}
