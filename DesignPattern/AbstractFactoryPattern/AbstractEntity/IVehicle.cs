using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractEntity
{
    public interface IVehicle
    {
        IBike GetBike(string bike);
        IScooter GetScooter(string scooter);

    }
}
