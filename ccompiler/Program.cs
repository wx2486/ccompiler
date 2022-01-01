namespace ccompiler
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var logger = new LogWriter(LogLevel.Debug);

            string[] sources = args.Select(file => File.ReadAllText(file)).ToArray();

            var compiler = new Compiler(sources);
            compiler.Compile();

            return 0;
        }
    }
}