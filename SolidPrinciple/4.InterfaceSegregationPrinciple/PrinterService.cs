using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.InterfaceSegregationPrinciple
{
    public class PrinterService
    {
        public void PrintPaper(IPrinter ipt)
        {
            ipt.Print();
        }
    }
}
