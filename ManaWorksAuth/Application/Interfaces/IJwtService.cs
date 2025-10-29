using ManaWorksAuth.Application.Dtos;

namespace ManaWorksAuth.Application.Interfaces;

public interface IJwtService
{
    TokenResult GenerateToken(string login, string nome, int usuarioId);
}