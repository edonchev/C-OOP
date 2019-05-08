using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Interfaces;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Tiger : Feline, IFood
    {
        public Tiger(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed)
        {
        }

        public void AskForFood()
        {
            Console.WriteLine("ROAR!!!");
        }

        public void Eat(Food food)
        {
            throw new NotImplementedException();
        }
    }
}
