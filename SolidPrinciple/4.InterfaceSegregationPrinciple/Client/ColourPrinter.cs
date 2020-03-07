using _4.InterfaceSegregationPrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.InterfaceSegregationPrinciple.Client
{
    public class ColourPrinter : IInkjet
    {
        public void PrintInkjetCopy()
        {
            Console.WriteLine("Inkjet Print");
        }
    }
}
