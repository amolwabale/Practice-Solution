using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            //If you have a base class, and you have a child class that extends it,
            //you should be able to use the child class wherever the base class is expected
            //– and everything should still work correctly.
            PrinterService ps = new PrinterService();
            ps.PrintPaper(new ColourPrinter());
            ps.PrintPaper(new LaserPrinter());
        }
    }
}
