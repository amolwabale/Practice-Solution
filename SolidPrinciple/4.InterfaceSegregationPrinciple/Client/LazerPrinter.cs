using _4.InterfaceSegregationPrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.InterfaceSegregationPrinciple.Client
{
    public class LazerPrinter : IlazerJet
    {
        public void PrintlazerjetCopy()
        {
            Console.WriteLine("Lazer Print");
        }
    }
}
