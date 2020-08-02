using AbstractFactoryPattern.AbstractEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteEntity
{
    public class SportsBike : IBike
    {
        public string Name()
        {
            return "Sports Bike";
        }
    }
}
