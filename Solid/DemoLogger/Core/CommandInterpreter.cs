using DemoLogger.Appenders;
using DemoLogger.Appenders.Contracts;
using DemoLogger.Core.Contracts;
using DemoLogger.Layouts;
using DemoLogger.Layouts.Contracts;
using DemoLogger.Loggers;
using DemoLogger.Loggers.Enums;
using System;
using System.Collections.Generic;

namespace DemoLogger.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private ICollection<IAppender> appenders;
        private IAppenderFactory appenderFactory;
        private ILayoutFactory layoutFactory;

        public CommandInterpreter()
        {
            this.appenders = new List<IAppender>();
            this.appenderFactory = new AppenderFactory();
            this.layoutFactory = new LayoutFactory();
        }

        public void AddAppender(string[] args)
        {
            string appenderType = args[0];
            string layoutType = args[1];
            ReportLevel reportLevel = ReportLevel.INFO; //Sets the report level to the lowest value in order to log all messages in case of no reportLevel given

            if (args.Length > 2)
            {
                reportLevel = Enum.Parse<ReportLevel>(args[2]); //Sets the report level to the given ReportLevel
            }
            
            var layout = layoutFactory.CreateLayout(layoutType);
            var appender = appenderFactory.CreateAppender(appenderType, layout);
            appender.ReportLevel = reportLevel;
            appenders.Add(appender);
        }

        public void AddMessage(string[] args)
        {
            foreach (var appender in appenders)
            {
                ReportLevel reportLevel = Enum.Parse<ReportLevel>(args[0]);
                string dateTime = args[1];
                string message = args[2];
                appender.Append(dateTime, reportLevel, message);
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Logger info");
            foreach (var appender in appenders)
            {
                Console.WriteLine(appender);
            }
        }
    }
}
