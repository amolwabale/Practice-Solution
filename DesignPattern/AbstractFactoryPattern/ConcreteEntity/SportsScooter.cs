using AbstractFactoryPattern.AbstractEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteEntity
{
    public class SportsScooter : IScooter
    {
        public string Name()
        {
            return "Sports Scooter";
        }
    }
}
