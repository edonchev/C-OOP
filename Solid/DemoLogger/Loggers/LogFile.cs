using DemoLogger.Loggers.Contracts;
using System.Linq;

namespace DemoLogger.Loggers
{
    public class LogFile : ILogFile
    {
        public int Size { get; private set; }

        public void Write(string message)
        {
            this.Size += message.Where(char.IsLetter).Sum(c => c);
        }
    }
}
