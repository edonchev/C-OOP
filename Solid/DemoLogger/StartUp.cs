﻿namespace DemoLogger
{
    using DemoLogger.Appenders;
    using DemoLogger.Appenders.Contracts;
    using DemoLogger.Layouts;
    using DemoLogger.Layouts.Contracts;
    using DemoLogger.Loggers;
    using DemoLogger.Loggers.Contracts;
    using DemoLogger.Loggers.Enums;

    public class StartUp
    {
        public static void Main()
        {
            var simpleLayout = new SimpleLayout();

            var consoleAppender = new ConsoleAppender(simpleLayout);
            consoleAppender.ReportLevel = ReportLevel.Error;

            var logger = new Logger(consoleAppender);

            logger.Info("3/31/2015 5:33:07 PM", "Everything seems fine");
            logger.Warning("3/31/2015 5:33:07 PM", "Warning: ping is too high - disconnect imminent");
            logger.Error("3/31/2015 5:33:07 PM", "Error parsing request");
            logger.Critical("3/31/2015 5:33:07 PM", "No connection string found in App.config");
            logger.Fatal("3/31/2015 5:33:07 PM", "mscorlib.dll does not respond");
        }
    }
}