using Topshelf.Logging;

namespace Topshelf.LibLog
{
    public class LibLogLoggerConfigurator : HostLoggerConfigurator
    {
        public LogWriterFactory CreateLogWriterFactory()
        {
            return new LibLogLogWriterFactory();
        }
    }
}