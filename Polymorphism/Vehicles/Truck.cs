using System;

namespace Vehicles
{
    internal class Truck : Vehicle
    {
        private static readonly double increasedFuelConsumption = 1.6;
        private static readonly double quantityLoss = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption + increasedFuelConsumption, tankCapacity)
        {
        }
    
        public override void Refuel(double liters)
        {
            
            if ((liters + FuelQuantity) > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                FuelQuantity += liters * quantityLoss;
            }
        }
    }
}
