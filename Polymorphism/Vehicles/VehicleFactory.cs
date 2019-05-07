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

            switch (vehicleType)
            {
                case "Car":
                    return new Car(fuelQuantity, litersPerKm);
                case "Truck":
                    return new Truck(fuelQuantity, litersPerKm);
                default:
                    return null;
            }
        }
    }
}
