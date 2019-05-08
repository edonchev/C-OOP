using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;
using WildFarm.Interfaces;

namespace WildFarm.Animals
{
    public class Cat : Feline, IFood
    {
        public Cat(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed)
        {
        }

        public void AskForFood()
        {
            Console.WriteLine("Meow"); ;
        }

        public void Eat(Food food)
        {
            throw new NotImplementedException();
        }
    }
}
