namespace Vehicles
{
    internal class Truck : Vehicle
    {
        private static readonly double increasedFuelConsumption = 1.6;
        private static readonly double quantityLoss = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption + increasedFuelConsumption)
        {
        }
    
        public override void Refuel(double liters)
        {
            FuelQuantity += liters * quantityLoss;
        }
    }
}
