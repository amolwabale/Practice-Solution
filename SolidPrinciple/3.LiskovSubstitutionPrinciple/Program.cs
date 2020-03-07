using _3.LiskovSubstitutionPrinciple.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Export obj = new ExportToPdf(); // Export to pdf can be substituted
            obj.Convert(@"c:\demo.txt");

            Export obj1 = new ExportToExcel(); // Export to Excel can be substituted
            obj1.Convert(@"c:\demo.txt");
        }
    }
}
