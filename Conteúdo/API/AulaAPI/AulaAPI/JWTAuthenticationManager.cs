using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AulaAPI
{
    public interface IJWTAuthenticationManager
    {
        string Authenticate(string username, string password);
    }

    public class JWTAuthenticationManager : IJWTAuthenticationManager
    {
        // SIMULANDO BD
        IDictionary<string, string> users = new Dictionary<string, string>
        {
            { "fabricio", "123" },
            { "londero", "456" }
        };

        private readonly string tokenKey;

        public JWTAuthenticationManager(string tokenKey)
        {
            this.tokenKey = tokenKey;
        }

        public string Authenticate(string username, string password)
        {
            //SIMULANDO CONSULTA DE BD PARA VALIDAR USUÁRIO
            if (!users.Any(u => u.Key == username && u.Value == password))
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(tokenKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, username)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}