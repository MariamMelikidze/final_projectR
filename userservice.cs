using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public class JwtService
{
    private readonly string _jwtSecretKey;

    public JwtService(string jwtSecretKey)
    {
        _jwtSecretKey = jwtSecretKey;
    }

    public string GenerateJwtToken(UserModel user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_jwtSecretKey);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, user.Username),
                
                new Claim(ClaimTypes.Role, "Admin"),
                new Claim(ClaimTypes.Role, "Moderator"),
                new Claim(ClaimTypes.Role, "Manager"),
                new Claim(ClaimTypes.Role, "Customer"),
                new Claim(ClaimTypes.Role, "Guest"),
                
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.DateOfBirth, user.DateOfBirth.ToString()),
                new Claim(ClaimTypes.MobilePhone, user.PhoneNumber),
                new Claim("Address", user.Address),
                
                new Claim("CustomClaim1", user.CustomClaim1),
                new Claim("CustomClaim2", user.CustomClaim2),
                
            }),
            Expires = DateTime.UtcNow.AddHours(1), 
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}
