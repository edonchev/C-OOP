using DemoLogger.Layouts.Contracts;

namespace DemoLogger.Layouts
{
    public class SimpleLayout : ILayout
    {
        public string Format => "{0} - {1} - {2}";
    }
}
