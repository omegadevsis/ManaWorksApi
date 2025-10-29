using ManaWorksAuth.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksAuth.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    
    public DbSet<User> users { get; set; }
}