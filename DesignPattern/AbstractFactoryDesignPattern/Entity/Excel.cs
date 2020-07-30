using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDesignPattern.Interface;

namespace AbstractFactoryDesignPattern.Entity
{
    public class Excel : IConvert
    {
        public void Convert()
        {
            Console.WriteLine("Converted to Excel");
        }
    }
}
