using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;
using WildFarm.Interfaces;

namespace WildFarm.Animals
{
    public class Owl : Bird, IFood
    {
        public Owl(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
        {
        }

        public void AskForFood()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public void Eat(Food food)
        {
            throw new NotImplementedException();
        }
    }
}
