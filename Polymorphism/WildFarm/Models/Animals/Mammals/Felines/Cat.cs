using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Cat : Feline
    {
        private static double GainValue = 0.3;

        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Meow");
        }

        public override void Eat(Food food)
        {
            BaseEat(food, new List<string> { nameof(Meat), nameof(Vegetable) }, GainValue);
        }
    }
}
