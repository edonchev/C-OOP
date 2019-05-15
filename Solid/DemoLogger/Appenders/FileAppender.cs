using DemoLogger.Appenders.Contracts;
using DemoLogger.Layouts.Contracts;
using DemoLogger.Loggers.Contracts;
using DemoLogger.Loggers.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoLogger.Appenders
{
    public class FileAppender : IAppender
    {
        private const string Path = @"..\..\..\log.txt";
        private readonly ILayout layout;
        private readonly ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile logFile)
        {
            this.layout = layout;
            this.logFile = logFile;
        }

        public ReportLevel ReportLevel { get; set; }

        public void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                string content = string.Format(this.layout.Format, dateTime, reportLevel, message) + Environment.NewLine;

                File.AppendAllText(Path, content);
            }
        }
    }
}
