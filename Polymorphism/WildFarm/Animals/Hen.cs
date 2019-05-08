using System;
using WildFarm.Foods;
using WildFarm.Interfaces;

namespace WildFarm.Animals
{
    public class Hen : Bird, IFood
    {
        public Hen(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
        {
        }

        public void AskForFood()
        {
            Console.WriteLine("Cluck");
        }

        public void Eat(Food food)
        {
            throw new NotImplementedException();
        }
    }
}
