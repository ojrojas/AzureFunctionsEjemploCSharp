using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface ITokenClaim
    {
        Task<string> GetTokenClaims(User user);
    }
}