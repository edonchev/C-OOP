using DemoLogger.Layouts.Contracts;

namespace DemoLogger.Appenders.Contracts
{
    public interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout);
    }
}
