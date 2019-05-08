using WildFarm.Foods;

namespace WildFarm.Interfaces
{
    interface IFood
    {
        void AskForFood();
        void Eat(Food food);
    }
}
