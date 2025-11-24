using ManaWorksApi.Application.Dtos.Auth;

namespace ManaWorksApi.Application.Interfaces.Auth;

public interface IJwtService
{
    TokenResult GenerateToken(string login, string nome, int usuarioId);
}