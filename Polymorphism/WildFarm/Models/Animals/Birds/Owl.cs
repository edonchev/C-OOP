using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Owl : Bird
    {
        private static double GainValue = 0.25;

        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override void Eat(Food food)
        {
            BaseEat(food, new List<string> { nameof(Meat) }, GainValue);
        }
    }
}
