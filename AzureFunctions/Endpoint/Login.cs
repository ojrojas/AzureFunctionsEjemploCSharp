using System.Net;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
namespace AzureFunctions
{
    public class Login
    {
        private readonly ILogger<Login> _logger;
        public Login(ILogger<Login> logger)
        {
            _logger = logger;
        }

        [Function("Login")] 
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "login")] HttpRequestData req,
            FunctionContext executionContext)
        {
            var logger = executionContext.GetLogger("Authentication - Login");
            logger.LogInformation("C# HTTP trigger function processed a request.");
            var response = req.CreateResponse(HttpStatusCode.OK);

            await response.WriteAsJsonAsync(new {Result="Todo bien, todo bien"});

            await Task.CompletedTask;
            return response;
        }
    }
}