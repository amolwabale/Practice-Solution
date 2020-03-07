using _4.InterfaceSegregationPrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.InterfaceSegregationPrinciple.Client
{
    public class AllInOne : IGreyScale, IInkjet, IlazerJet
    {
        public void PrintGreyScaleCopy()
        {
            Console.WriteLine("GreyScale Print");
        }

        public void PrintInkjetCopy()
        {
            Console.WriteLine("Inkjet Print");
        }

        public void PrintlazerjetCopy()
        {
            Console.WriteLine("lazer Print");
        }
    }
}
