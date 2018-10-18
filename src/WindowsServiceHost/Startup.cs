using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WindowsServiceHost
{
    public class Startup
    {
        public Startup()
        {
            //log4net.Config.XmlConfigurator.Configure(log4net.LogManager.GetRepository(System.Reflection.Assembly.GetEntryAssembly()), new System.IO.FileInfo("log4net.config"));
        }

        public void ConfigureServices(IServiceCollection services, HostBuilderContext hostContext)
        {

        }
    }
}
