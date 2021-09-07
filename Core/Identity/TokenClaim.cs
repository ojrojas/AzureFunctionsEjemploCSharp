using Core.Entities;
using Core.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
  

    public class TokenClaim : ITokenClaim
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<TokenClaim> _logger;

        public TokenClaim(IConfiguration configuration, ILogger<TokenClaim> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public async Task<string> GetTokenClaims(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["JwtOptions:JwtSecret"]);
            var claims = new List<Claim>();
            _logger.LogInformation("Create auth token application");

            foreach (PropertyInfo prop in user.GetType().GetProperties())
            {
                _ = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                if (prop.Name != "Password")
                    if (prop.GetValue(user, null) != null)
                        claims.Add(new Claim(prop.Name, prop.GetValue(user, null).ToString()));
            }

            await Task.CompletedTask;

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims.ToArray()),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}