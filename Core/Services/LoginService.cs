using System.Threading.Tasks;
using Core.BaseHttp.HttpMessages.Login;
using Core.Entities;
using Core.Interfaces;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;

namespace Core.Services
{
   

    public class LoginService : ILoginService
    {
        private readonly IAsyncRepository<User> _loginRepository;
        private readonly ILogger<LoginService> _logger;
        private readonly ITokenClaim _tokenClaim;

        public LoginService(IAsyncRepository<User> loginRepository, ILogger<LoginService> logger, ITokenClaim tokenClaim)
        {
            _loginRepository = loginRepository;
            _logger = logger;
            _tokenClaim = tokenClaim;
        }

        public async Task<LoginResponse> Login(LoginRequest loginRequest)
        {
            _logger.LogInformation("Login Services", JsonConvert.SerializeObject(loginRequest));
            var response = new LoginResponse(loginRequest.CorrelationId);
            var users = await _loginRepository.ListAsync();
            var userLogged = users.FirstOrDefault(x=> x.UserName == loginRequest.UserName && x.Password == loginRequest.Password);
            response.Token = userLogged != null ? await _tokenClaim.GetTokenClaims(userLogged) : string.Empty;
            return response;
        }
    }
}