using ManaWorksApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    
    public DbSet<Usuario> usuarios { get; set; }
    public DbSet<Perfil> perfis { get; set; }
    public DbSet<Permissao> permissoes { get; set; }
    public DbSet<PermissaoGrupo> permissaogrupos { get; set; }
    public DbSet<PerfilPermissao> perfilpermissoes { get; set; }
    public DbSet<Modulo> modulos { get; set; }
    public DbSet<UsuarioModulo> usuariomodulos { get; set; }
}