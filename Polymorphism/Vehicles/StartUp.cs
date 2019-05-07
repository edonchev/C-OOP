using System;

namespace Vehicles
{
    class StartUp
    {
        static void Main()
        {
            Car car = (Car)VehicleFactory.CreateVehicle();
            Truck truck = (Truck)VehicleFactory.CreateVehicle();
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string action = commands[0];
                string vehicleType = commands[1];
                double argument = double.Parse(commands[2]);

                ExecuteAction(car, truck, action, vehicleType, argument);
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static void ExecuteAction(Car car, Truck truck, string action, string vehicleType, double argument)
        {
            switch (action)
            {
                case "Drive":
                    if (vehicleType == "Car")
                    {
                        Console.WriteLine(car.Drive(argument));
                    }
                    else if (vehicleType == "Truck")
                    {
                        Console.WriteLine(truck.Drive(argument));
                    }
                    break;
                case "Refuel":
                    if (vehicleType == "Car")
                    {
                        car.Refuel(argument);
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Refuel(argument);
                    }
                    break;
            }
        }
    }
}
