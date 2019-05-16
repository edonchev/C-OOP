using DemoLogger.Appenders;
using DemoLogger.Appenders.Contracts;
using DemoLogger.Core.Contracts;
using DemoLogger.Layouts;
using DemoLogger.Layouts.Contracts;
using DemoLogger.Loggers.Enums;
using System;
using System.Collections.Generic;
using System.Text;

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
            ReportLevel reportLevel = ReportLevel.Info; //Sets the report level to the lowest value in order to log all messages in case of no reportLevel given

            if (args.Length > 2)
            {
                reportLevel = Enum.Parse<ReportLevel>(args[2]);
            }
            //Create an istance of an Appender for the given appenderType
            //Create an instance of a Layout for the given layout type

            appenderFactory.CreateAppender(appenderType, );
            //Add this instance to the list of appenders
        }

        public void AddMessage(string[] args)
        {
            
        }

        public void PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
