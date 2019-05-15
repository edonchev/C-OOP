using DemoLogger.Appenders.Contracts;
using DemoLogger.Layouts.Contracts;
using DemoLogger.Loggers.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLogger.Appenders
{
    public class ConsoleAppender : IAppender
    {
        private readonly ILayout layout;

        public ConsoleAppender(ILayout layout)
        {
            this.layout = layout;
        }

        public ReportLevel ReportLevel { get; set; }

        public void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                Console.WriteLine(string.Format(this.layout.Format, dateTime, reportLevel, message));
            }
        }
    }
}
