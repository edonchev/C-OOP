using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Dog : Mammal
    {
        private static double GainValue = 0.4;

        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Woof!");
        }

        public override void Eat(Food food)
        {
            BaseEat(food, new List<string> { nameof(Meat) }, GainValue);
        }

        //public override string ToString()
        //{
        //    return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        //}
    }
}
