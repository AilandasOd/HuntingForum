using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PVP.Server.Helpers.Services
{
    public class JwtService
    {
        private readonly SymmetricSecurityKey _authSigningKey;
        private readonly string? _issuer;
        private readonly string? _audience;

        public JwtService(IConfiguration configuration)
        {
            _authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));
            _issuer = configuration["JWT:ValidIssuer"];
            _audience = configuration["JWT:ValidAudience"];
        }

        public string Generate(string username, string userId, string role)
        {
            var authClaims = new List<Claim>
    {
        new(ClaimTypes.Name, username),
        new(JwtRegisteredClaimNames.Sub, userId),
        new(ClaimTypes.Role, role), // Add role claim
        new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
    };

            var token = new JwtSecurityToken(
                issuer: _issuer,
                audience: _audience,
                expires: DateTime.Now.AddMinutes(20),
                claims: authClaims,
                signingCredentials: new SigningCredentials(_authSigningKey, SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public JwtSecurityToken Verify(string jwt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            tokenHandler.ValidateToken(jwt, new TokenValidationParameters
            {
                IssuerSigningKey = _authSigningKey,
                ValidateIssuerSigningKey = true,
                ValidateIssuer = !string.IsNullOrEmpty(_issuer),
                ValidateAudience = !string.IsNullOrEmpty(_audience),
                ValidIssuer = _issuer,
                ValidAudience = _audience
            }, out SecurityToken validatedToken);

            return (JwtSecurityToken)validatedToken;
        }
    }
}
