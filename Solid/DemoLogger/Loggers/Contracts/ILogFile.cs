namespace DemoLogger.Loggers.Contracts
{
    public interface ILogFile
    {
        int Size { get; }
        void Write(string message);
    }
}
