using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ManaWorksAuth.Api.Configuration;
using ManaWorksAuth.Application.Dtos;
using ManaWorksAuth.Application.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace ManaWorksAuth.Infrastructure.Security;

public class JwtService : IJwtService
{
    private readonly JwtSettings _settings;

    public JwtService(IOptions<JwtSettings> options)
    {
        _settings = options.Value;
    }

    public TokenResult GenerateToken(string login, string nome, int usuarioId)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_settings.SecretKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(ClaimTypes.Name, login),
            new Claim(ClaimTypes.NameIdentifier, nome),
            new Claim("UsuarioId", usuarioId.ToString())
        };

        var token = new JwtSecurityToken(
            issuer: _settings.Issuer,
            audience: _settings.Audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(_settings.ExpirationMinutes),
            signingCredentials: creds
        );

        var tokenResult = new TokenResult
        {
            Token = new JwtSecurityTokenHandler().WriteToken(token),
            Expires = token.ValidTo.ToString()
        };

        return tokenResult;
        //return new JwtSecurityTokenHandler().WriteToken(token);
    }
}