using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private static readonly double increasedFuelConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption + increasedFuelConsumption, tankCapacity)
        {
        }
    }
}
