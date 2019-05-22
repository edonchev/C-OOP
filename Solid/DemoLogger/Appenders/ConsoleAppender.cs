using DemoLogger.Appenders.Contracts;
using DemoLogger.Layouts.Contracts;
using DemoLogger.Loggers.Enums;
using System;

namespace DemoLogger.Appenders
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            :base(layout)
        {
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                Console.WriteLine(string.Format(this.Layout.Format, dateTime, reportLevel, message));
                this.MessagesAppended++;
            }
        }
    }
}
