using Microsoft.Extensions.Hosting;
using AzureFunctions.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace AzureFunctions
{
    public class Program
    {
        public static void Main()
        {
            var host = new HostBuilder();
            host
             .ConfigureServices(services =>
                {
                   services
                    .AddServiceExtensionDM();
                    services.BuildServiceProvider();
                })
                .ConfigureFunctionsWorkerDefaults()
               
                .Build().Run();
        }
    }
}