namespace ccompiler
{
    public class Compiler
    {
        private string[] sources;
        private LogWriter logger;

        public Compiler(string[] sources, LogWriter logWriter)
        {
            this.sources = sources;
            logger = logWriter;
        }
        
        public void Compile()
        {
            foreach (string source in sources)
            {

            }
        }
    }
}
