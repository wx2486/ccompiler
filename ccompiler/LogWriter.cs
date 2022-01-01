namespace ccompiler
{
    public class LogWriter
    {
        public LogLevel LogLevel;

        public LogWriter(LogLevel logLevel)
        {
            LogLevel = logLevel;
        }
        
        public void Log(string log)
        {
            Log(LogLevel.Info, log);
        }

        public void Log(LogLevel logLevel, string log)
        {
            if (logLevel <= LogLevel)
            {
                Console.WriteLine(log);
            }
        }
    }

    public enum LogLevel
    {
        Critical,
        Error,
        Warning,
        Info,
        Debug,
    };
}
