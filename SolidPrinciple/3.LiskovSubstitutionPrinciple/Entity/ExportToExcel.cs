using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.LiskovSubstitutionPrinciple.Entity
{
    public class ExportToExcel : Export
    {
        public override void Convert(string path)
        {
            Console.WriteLine("ExportToExcel");
        }
    }
}
