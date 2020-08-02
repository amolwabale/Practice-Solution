using AbstractFactoryPattern.AbstractEntity;
using AbstractFactoryPattern.ConcreteEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteFactoryEntity
{
    public class HondaFactory : IVehicle
    {
        public IBike GetBike(string bike)
        {
            switch(bike)
            {
                case "sports":
                    return new SportsBike();
                case "Regular":
                    return new RegularBike();
                default:
                    throw new Exception("No bike found");
            }
        }

        public IScooter GetScooter(string scooter)
        {
            switch (scooter)
            {
                case "sports":
                    return new SportsScooter();
                case "Regular":
                    return new RegularScooter();
                default:
                    throw new Exception("No Scooter found");
            }
        }
    }
}
