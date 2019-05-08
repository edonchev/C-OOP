using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public abstract class Bird : Animal
    {
        public Bird(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten)
        {
            WingSize = wingSize;
        }
        public double WingSize { get; set; }
    }
}
