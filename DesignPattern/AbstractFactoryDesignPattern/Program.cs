using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDesignPattern.AbstractFactoryEntity;
using AbstractFactoryDesignPattern.FactoryEntity;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory obj = new FactoryOne();
            var a = obj.CreateConvert();
            a.Convert();
        }
    }
}
