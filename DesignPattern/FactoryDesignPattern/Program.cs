using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryDesignPattern.Constant;

namespace FactoryDesignPattern
{
    class Program
    {
        //When to us Factory design Pattern?
        //When to object creatoin is complex and you wish to make it abstract to the consumer.
        //it is required to take runtime decision for class creation.
        //Converion logic like - pdf, excel, word,
        //Payment system - credit card, debit card, upi, netbanking

        static void Main(string[] args)
        {
            var dbFactory = new DatabaseFactory();
            var instance = dbFactory.GetDatabase(eDbType.Sql);
        }
    }
}
