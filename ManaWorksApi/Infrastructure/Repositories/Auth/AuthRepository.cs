using ManaWorksApi.Application.Dtos.Auth;
using ManaWorksApi.Application.Interfaces.Auth;
using ManaWorksApi.Infrastructure.Persistence;

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories.Auth;

public class AuthRepository : IAuthRepository
{
    private readonly AppDbContext _context;
    private readonly IEncryptionService _encryptionService;
    private readonly IJwtService _jwtService;

    public AuthRepository(AppDbContext context, IEncryptionService encryptionService,  
        IJwtService jwtService)
    {
        _context = context;
        _encryptionService = encryptionService;
        _jwtService = jwtService;
    }
    
    public async Task<UserAuthResult?> GetUser(string login, string senha)
    {
        var usuario = await (from u in _context.users
            join p in _context.profiles on u.ProfileId equals p.ProfileId
            where u.Login == login && u.Password == _encryptionService.EncryptString(senha)
            select new UserAuthResult
            {
                Login = u.Login,
                Name = u.Name,
                ProfileId = u.ProfileId,
                UserId = u.UserId,
                ProfileName = p.ProfileName
            }).AsNoTracking().FirstOrDefaultAsync();
        
        var token = _jwtService.GenerateToken(usuario.Login, usuario.Name, usuario.UserId );
        usuario.Token = token.Token;
        usuario.Expires = token.Expires;

        return usuario;
    }
    
   
}