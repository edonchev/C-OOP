using DemoLogger.Appenders;
using DemoLogger.Appenders.Contracts;
using DemoLogger.Loggers.Contracts;
using DemoLogger.Loggers.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLogger.Loggers
{
    public class Logger : ILogger
    {
        private readonly IAppender consoleAppender;
        private readonly IAppender fileAppender;

        public Logger(IAppender consoleAppender)
        {
            this.consoleAppender = consoleAppender;
        }

        public Logger(IAppender consoleAppender, IAppender fileAppender) 
            : this(consoleAppender)
        {
            this.fileAppender = fileAppender;
        }

        public void Info(string dateTime, string infoMessage)
        {
            Append(dateTime, ReportLevel.Info, infoMessage);
        }

        public void Warning(string dateTime, string warningMessage)
        {
            Append(dateTime, ReportLevel.Warning, warningMessage);
        }

        public void Error(string dateTime, string errorMessage)
        {
            Append(dateTime, ReportLevel.Error, errorMessage);
        }

        public void Critical(string dateTime, string criticalMessage)
        {
            Append(dateTime, ReportLevel.Critical, criticalMessage);
        }

        public void Fatal(string dateTime, string fatalMessage)
        {
            Append(dateTime, ReportLevel.Fatal, fatalMessage);
        }

        private void Append(string dateTime, ReportLevel type, string message)
        {
            consoleAppender?.Append(dateTime, type, message);
            fileAppender?.Append(dateTime, type, message);
        }
    }
}
