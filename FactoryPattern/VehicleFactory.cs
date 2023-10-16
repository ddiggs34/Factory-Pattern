using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numOfWheels)
        {
            switch (numOfWheels)
            {

                case 4:
                    return new Car(); //will return a type of IVehicle
                case 2:
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }
    }
}
