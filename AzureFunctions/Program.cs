using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Azure.Functions.Worker.Configuration;
using AzureFunctions.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Infraestructure;
using Microsoft.EntityFrameworkCore;

namespace AzureFunctions
{
    public class Program
    {
        public static void Main()
        {
            IConfiguration configuracion = default;
            var host = new HostBuilder();
            host
                .ConfigureFunctionsWorkerDefaults()
                .ConfigureServices(services =>
                {
                    services.AddDbContext<AzureFunctionsDbContext>(
                        options => options.UseSqlite(configuracion.GetConnectionString("ConnectionSqlite")))
                    .AddServiceExtensionDM();
                })
                .Build().Run();
        }
    }
}