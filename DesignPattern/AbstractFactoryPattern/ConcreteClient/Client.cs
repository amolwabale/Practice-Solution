
using AbstractFactoryPattern.AbstractEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteClient
{
    public class Client
    {
        private IBike _bike;
        private IScooter _scooter;

        public Client(IVehicle vehicle, string type)
        {
            _bike = vehicle.GetBike(type);
            _scooter = vehicle.GetScooter(type);
        }

        public string GetBikeName()
        {
            return _bike.Name();
        }

        public string GetScooterName()
        {
            return _scooter.Name();
        }
    }
}
