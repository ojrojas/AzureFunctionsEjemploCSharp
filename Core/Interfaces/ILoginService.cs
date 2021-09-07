using System.Threading.Tasks;
using Core.BaseHttp.HttpMessages.Login;

namespace Core.Interfaces
{
    public interface ILoginService
    {
        Task<LoginResponse> Login(LoginRequest loginRequest);
    }
}