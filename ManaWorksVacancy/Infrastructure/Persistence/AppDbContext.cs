using ManaWorksVacancy.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksVacancy.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    
    public DbSet<Vacancy> vacancies { get; set; }
    public DbSet<JourneyType> journeytypes { get; set; }
    public DbSet<ContractType> contracttypes { get; set; }
    public DbSet<WorkType> worktypes { get; set; }
}