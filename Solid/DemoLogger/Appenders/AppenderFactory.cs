using DemoLogger.Appenders.Contracts;
using DemoLogger.Layouts.Contracts;
using DemoLogger.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLogger.Appenders
{
    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout)
        {
            switch (type)
            {
                case "ConsoleAppender":
                    return new ConsoleAppender(layout);
                case "FileAppender":
                    return new FileAppender(layout, new LogFile());
                default:
                    throw new ArgumentException("Invalid appender type");
            }
        }
    }
}
