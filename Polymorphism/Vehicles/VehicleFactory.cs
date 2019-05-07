using System;

namespace Vehicles
{
    public static class VehicleFactory
    {
        public static Vehicle CreateVehicle()
        {
            string[] vehicle = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string vehicleType = vehicle[0];
            double fuelQuantity = double.Parse(vehicle[1]);
            double litersPerKm = double.Parse(vehicle[2]);
            double tankCapacity = double.Parse(vehicle[3]);

            switch (vehicleType)
            {
                case "Car":
                    return new Car(fuelQuantity, litersPerKm, tankCapacity);
                case "Truck":
                    return new Truck(fuelQuantity, litersPerKm, tankCapacity);
                case "Bus":
                    return new Bus(fuelQuantity, litersPerKm, tankCapacity);
                default:
                    return null;
            }
        }
    }
}
