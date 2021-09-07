using System.IO;
using System.Net;
using System.Threading.Tasks;
using Core.BaseHttp.HttpMessages.Login;
using Core.Interfaces;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AzureFunctions
{
    public class Login
    {
        private readonly ILogger<Login> _logger;
        private readonly ILoginService _loginService;

        public Login(ILogger<Login> logger, ILoginService loginService)
        {
            _logger = logger;
            _loginService = loginService;
        }

        [Function("Login")] 
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "login")] HttpRequestData req,
            FunctionContext executionContext)
        {
            var logger = executionContext.GetLogger("Authentication - Login");
            logger.LogInformation("C# HTTP trigger function processed a request.");
            var response = req.CreateResponse(HttpStatusCode.OK);
            var body = await new StreamReader(req.Body).ReadToEndAsync();
            var loginRequest = JsonConvert.DeserializeObject<LoginRequest>(body);

            await response.WriteAsJsonAsync(_loginService.Login(loginRequest));

            await Task.CompletedTask;
            return response;
        }
    }
}