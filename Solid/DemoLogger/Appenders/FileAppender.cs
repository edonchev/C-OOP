using DemoLogger.Appenders.Contracts;
using DemoLogger.Layouts.Contracts;
using DemoLogger.Loggers.Contracts;
using DemoLogger.Loggers.Enums;
using System;
using System.IO;

namespace DemoLogger.Appenders
{
    public class FileAppender : Appender
    {
        private const string Path = @"..\..\..\log.txt";

        public FileAppender(ILayout layout, ILogFile logFile) : base(layout)
        {
            this.LogFile = logFile;
        }

        private ILogFile LogFile { get; }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                string content = string.Format(this.Layout.Format, dateTime, reportLevel, message) + Environment.NewLine;

                File.AppendAllText(Path, content);
                MessagesAppended++;
                LogFile.Write(content);
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, File size: {LogFile.Size}";
        }
    }
}
