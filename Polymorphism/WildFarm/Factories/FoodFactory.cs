using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Factories
{
    public static class FoodFactory
    {
        public static Food Create(params string[] foodArgs)
        {
            string foodType = foodArgs[0];
            int quantity = int.Parse(foodArgs[1]);

            if (foodType == nameof(Vegetable))
            {
                return new Vegetable(quantity);
            }
            else if (foodType == nameof(Fruit))
            {
                return new Fruit(quantity);
            }
            else if (foodType == nameof(Meat))
            {
                return new Meat(quantity);
            }
            else if (foodType == nameof(Seeds))
            {
                return new Seeds(quantity);
            }
            return null;
        }
    }
}
