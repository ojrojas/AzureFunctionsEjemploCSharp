using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace AzureFunctions
{
    public class Login
    {
        public Login() { }

        [Function("Login")]
        public async Task<HttpResponseData> Run(
            [HttpTrigger(AuthorizationLevel.User, "post", Route = "Login")] HttpRequestData req,
            FunctionContext executionContext)
        {
            return null;
        }
    }
}