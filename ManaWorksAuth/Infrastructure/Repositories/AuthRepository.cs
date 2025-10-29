using ManaWorksAuth.Application.Dtos;
using ManaWorksAuth.Application.Interfaces;
using ManaWorksAuth.Domain.Entities;
using ManaWorksAuth.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksAuth.Infrastructure.Repositories;

public class AuthRepository : IAuthRepository
{
    private readonly AppDbContext _context;
    private readonly IEncryptionService _encryptionService;

    public AuthRepository(AppDbContext context, IEncryptionService encryptionService)
    {
        _context = context;
        _encryptionService = encryptionService;
    }
    
    public async Task<UserAuthResult?> GetUser(string login, string senha)
    {
        var usuario = await (from u in _context.users
            where u.UserLogin == login && u.UserPassword == _encryptionService.EncryptString(senha)
            select new UserAuthResult
            {
                Login = u.UserLogin,
                Nome = u.UserName,
                PerfilId = u.ProfileId,
                UsuarioId = u.UserId
            }).AsNoTracking().FirstOrDefaultAsync();

        return usuario;
    }
    
    public async Task AddUserAsync(User user)
    {
        await _context.users.AddAsync(user);
        await _context.SaveChangesAsync();
    }
}