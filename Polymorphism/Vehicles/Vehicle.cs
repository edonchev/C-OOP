using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public double TankCapacity { get; set; }

        public virtual string Drive(double distance)
        {
            double necessaryFuel = distance * FuelConsumption;
            if (FuelQuantity >= necessaryFuel)
            {
                FuelQuantity -= necessaryFuel;
                return $"{GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{GetType().Name} needs refueling";
            }
        }

        public virtual string Drive(double distance, double increasedFuelConsumption)
        {
            double necessaryFuel = distance * (FuelConsumption + increasedFuelConsumption);
            if (FuelQuantity >= necessaryFuel)
            {
                FuelQuantity -= necessaryFuel;
                return $"{GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{GetType().Name} needs refueling";
            }
        }

        public virtual void Refuel(double liters)
        {
            if ((liters + FuelQuantity) > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                FuelQuantity += liters;
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:F2}";
        }
    }
}
