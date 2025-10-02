using ManaWorksApi.Application.Domain;
using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories;

public class LoginRepository : ILoginRepository
{
    private readonly AppDbContext _context;
    private readonly ICriptografiaService _criptografiaService;

    public LoginRepository(AppDbContext context, ICriptografiaService criptografiaService)
    {
        _context = context;
        _criptografiaService = criptografiaService;
    }
    
    public async Task<UsuarioLoginResult?> GetUser(string login, string senha)
    {
        var usuario = await (from u in _context.usuarios
            where u.Login == login && u.Senha == _criptografiaService.EncryptString(senha)
            select new UsuarioLoginResult
            {
                Login = u.Login,
                Nome = u.Nome,
                PerfilId = u.PerfilId,
                PerfilNome = u.Perfil.PerfilNome,
                UsuarioId = u.UsuarioId
            }).AsNoTracking().FirstOrDefaultAsync();

        return usuario;
    }
}