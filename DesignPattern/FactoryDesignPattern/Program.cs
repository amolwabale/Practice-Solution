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
        //Factory method defined interface for creating an object but let 
        //sub class decides which object to create.

        //Client -> Factory -> Product

        //When to us Factory design Pattern?
        //1. The object needs to be extended to subclass
        //2. The class doesnt know what sub-class it has to create.
        //3. The product implementation tend to change over time and client remains unchanged.
        static void Main(string[] args)
        {
            var dbFactory = new DatabaseFactory();
            var instance = dbFactory.GetDatabase(eDbType.Sql);
        }
    }
}
