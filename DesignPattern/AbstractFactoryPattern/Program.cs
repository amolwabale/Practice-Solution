using AbstractFactoryPattern.ConcreteClient;
using AbstractFactoryPattern.ConcreteFactoryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client obj = new Client(new HondaFactory(), "Sports");
            var bikeName = obj.GetBikeName();
            var scooterName = obj.GetScooterName();
        }
    }
}
