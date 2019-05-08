using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;
using WildFarm.Interfaces;

namespace WildFarm.Animals
{
    public class Dog : Mammal, IFood
    {
        public Dog(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion)
        {
        }

        public void AskForFood()
        {
            Console.WriteLine("Woof!");
        }

        public void Eat(Food food)
        {
            throw new NotImplementedException();
        }
    }
}
