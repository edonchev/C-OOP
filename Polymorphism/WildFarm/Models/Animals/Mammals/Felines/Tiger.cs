using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Tiger : Feline
    {
        private static double GainValue = 1;

        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("ROAR!!!");
        }

        public override void Eat(Food food)
        {
            BaseEat(food, new List<string> { nameof(Meat) }, GainValue);
        }
    }
}
