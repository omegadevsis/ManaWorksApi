using ManaWorksApi.Application.Domain;
using ManaWorksApi.Domain.Entities;

namespace ManaWorksApi.Application.Interfaces;

public interface IJwtService
{
    TokenResult GenerateToken(string login, string nome, int usuarioId);
}