using Blog.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Blog.Services {
	public class TokenService {
        public string GenerateToken(User user) {
            var tokenHandler = new JwtSecurityTokenHandler(); // Crição de instância do token
            var key = Encoding.ASCII.GetBytes(Configuration.JwtKey); // Codificando a chave em Bytes
            var tokenDescriptor = new SecurityTokenDescriptor() { // Especificação do token
                Subject = new ClaimsIdentity(new Claim[] {
                    new (ClaimTypes.Name, user.Name), // User.Identity.Name
                    new (ClaimTypes.Role, user.Roles), // User.IsInRole
                }),
                Expires = DateTime.UtcNow.AddHours(1), // Duração de 2 a 8 horas é indicado
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            }; 
            var token = tokenHandler.CreateToken(tokenDescriptor); // Criação do token

            return tokenHandler.WriteToken(token);
        }
    }
}
