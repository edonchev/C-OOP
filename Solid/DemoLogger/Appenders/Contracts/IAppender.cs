using DemoLogger.Layouts.Contracts;
using DemoLogger.Loggers.Enums;

namespace DemoLogger.Appenders.Contracts
{
    public interface IAppender
    {
        int MessagesAppended { get; set; }

        ILayout Layout { get; }

        ReportLevel ReportLevel { get; set; }

        void Append(string dateTime, ReportLevel reportLevel, string message);
    }
}
