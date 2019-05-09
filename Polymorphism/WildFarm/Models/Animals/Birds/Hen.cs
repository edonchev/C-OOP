using System;
using System.Collections.Generic;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Hen : Bird
    {
        private static double GainValue = 0.35;
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }
  
        public override void AskForFood()
        {
            Console.WriteLine("Cluck");
        }

        public override void Eat(Food food)
        {
            BaseEat(food, new List<string> { nameof(Fruit), nameof(Meat), nameof(Seeds), nameof(Vegetable) }, GainValue);
        }
    }
}
