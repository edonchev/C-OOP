using System;
using System.Collections.Generic;
using WildFarm.Animals;
using WildFarm.Factories;
using WildFarm.Foods;

namespace WildFarm
{
    public class StartUp
    {
        static void Main()
        {
            string input;
            List<Animal> animals = new List<Animal>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] animalArgs = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Animal animal = AnimalFactory.Create(animalArgs);

                string[] foodArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Food food = FoodFactory.Create(foodArgs);

                animal.AskForFood();
                try
                {
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                animals.Add(animal);
            }

            foreach (Animal a in animals)
            {
                Console.WriteLine(a);
            }
        }
    }
}
