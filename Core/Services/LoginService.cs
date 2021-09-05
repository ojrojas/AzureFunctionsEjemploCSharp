using System.Threading.Tasks;
using Core.BaseHttp.HttpMessages.Login;
using Core.Entities;
using Core.Interfaces;
using Microsoft.Extensions.Logging;

namespace Core.Services
{
    public class LoginService
    {
        private readonly IAsyncRepository<User> _loginRepository;
        private readonly ILogger<LoginService> _logger;

        public LoginService(IAsyncRepository<User> loginRepository, ILogger<LoginService> logger)
        {
            _loginRepository = loginRepository;
            _logger = logger;
        }

        public async Task<LoginResponse> Login(LoginRequest loginRequest)
        {
           
            var response = new LoginResponse(loginRequest.CorrelationId)
            {
                Token = "ALSLLDKDKF"
            };

            await Task.CompletedTask;

            return response;
        }
    }
}