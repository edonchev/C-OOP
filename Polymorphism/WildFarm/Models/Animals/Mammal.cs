using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, double weight, int foodEaten, string livingRegion) 
            : base(name, weight, foodEaten)
        {
            LivingRegion = livingRegion;
        }

        public string LivingRegion { get; set; }
    }
}
