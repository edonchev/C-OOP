﻿using DemoLogger.Appenders.Contracts;
using DemoLogger.Loggers.Contracts;
using DemoLogger.Loggers.Enums;

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
            Append(dateTime, ReportLevel.INFO, infoMessage);
        }

        public void Warning(string dateTime, string warningMessage)
        {
            Append(dateTime, ReportLevel.WARNING, warningMessage);
        }

        public void Error(string dateTime, string errorMessage)
        {
            Append(dateTime, ReportLevel.ERROR, errorMessage);
        }

        public void Critical(string dateTime, string criticalMessage)
        {
            Append(dateTime, ReportLevel.CRITICAL, criticalMessage);
        }

        public void Fatal(string dateTime, string fatalMessage)
        {
            Append(dateTime, ReportLevel.FATAL, fatalMessage);
        }

        private void Append(string dateTime, ReportLevel type, string message)
        {
            consoleAppender?.Append(dateTime, type, message);
            fileAppender?.Append(dateTime, type, message);
        }
    }
}
