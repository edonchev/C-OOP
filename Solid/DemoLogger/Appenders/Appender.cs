using DemoLogger.Appenders.Contracts;
using DemoLogger.Layouts.Contracts;
using DemoLogger.Loggers.Enums;

namespace DemoLogger.Appenders
{
    public abstract class Appender : IAppender
    {
        public int MessagesAppended { get; set; }
        public ILayout Layout { get; }
        public ReportLevel ReportLevel { get; set; }

        public Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel}, Messages appended: {this.MessagesAppended}";
        }
    }
}
