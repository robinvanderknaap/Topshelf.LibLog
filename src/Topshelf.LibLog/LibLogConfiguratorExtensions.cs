using Topshelf.HostConfigurators;
using Topshelf.Logging;

namespace Topshelf.LibLog
{
    public static class LibLogConfiguratorExtensions
    {
        public static void UseLibLog(this HostConfigurator configurator)
        {
            HostLogger.UseLogger(new LibLogLoggerConfigurator());
        }
    }
}
