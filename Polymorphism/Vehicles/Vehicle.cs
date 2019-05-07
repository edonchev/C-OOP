using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get
            {
                return FuelQuantity;
            }
            set
            {
                if (FuelQuantity > TankCapacity)
                {
                    FuelQuantity = 0;
                }
                else
                {
                    FuelQuantity = value;
                }
            }
        }
        public double FuelConsumption { get; set; }
        public double TankCapacity { get; set; }

        public virtual string  Drive(double distance)
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

        public virtual void Refuel(double liters)
        {
            FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:F2}";
        }
    }
}
