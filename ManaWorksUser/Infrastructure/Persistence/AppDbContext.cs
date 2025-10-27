using ManaWorksUser.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksUser.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    
    public DbSet<User> users { get; set; }
}