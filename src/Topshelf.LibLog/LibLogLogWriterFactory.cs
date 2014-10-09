using Topshelf.Logging;

namespace Topshelf.LibLog
{
    public class LibLogLogWriterFactory : LogWriterFactory
    {
        public LogWriter Get(string name)
        {
            return new LibLogLogWriter(name);
        }

        public void Shutdown()
        {
        }
    }
}