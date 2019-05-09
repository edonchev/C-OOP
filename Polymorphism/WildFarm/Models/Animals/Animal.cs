using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; protected set; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }

        public abstract void AskForFood();

        public abstract void Eat(Food food);

        protected void BaseEat(Food food, List<string> eatableFood, double gainValue)
        {
            string foodType = food.GetType().Name;
            if (!eatableFood.Contains(foodType))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {foodType}!");
            }
            this.Weight += food.Quantity * gainValue;
            this.FoodEaten += food.Quantity;
        }
    }
}
