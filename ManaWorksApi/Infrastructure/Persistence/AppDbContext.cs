using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Domain.Entities.Candidate;
using ManaWorksApi.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    
    public DbSet<User> users { get; set; }
    public DbSet<Profile> profiles { get; set; }
    public DbSet<Candidate> candidates { get; set; }
    public DbSet<CandidateAddress> candidateaddresses { get; set; }
    public DbSet<CandidateContact> candidatecontacts { get; set; }
    public DbSet<CandidateCourse> candidatecourses { get; set; }
    public DbSet<CandidateDocument> candidatedocuments { get; set; }
    public DbSet<CandidateEducation> candidateeducations { get; set; }
    public DbSet<CandidateExperience> candidateexperiences { get; set; }
    public DbSet<CandidateObjective> candidateobjectives { get; set; }
    public DbSet<CandidateStatus> candidatestatus { get; set; }
    public DbSet<CandidateSelection> candidateselections { get; set; }
    public DbSet<WorkTime> worktimes { get; set; }
    public DbSet<Marital> maritals { get; set; }
    public DbSet<FunctionWork> functionworks { get; set; }
    public DbSet<EducationType> educationtypes { get; set; }
    public DbSet<ExperienceTime> experiencetimes { get; set; }
    public DbSet<Vacancy> vacancies { get; set; }
    public DbSet<JourneyType> journeytypes { get; set; }
    public DbSet<ContractType> contracttypes { get; set; }
    public DbSet<WorkType> worktypes { get; set; }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<User>()
    //         .Property(u => u.Status)
    //         .HasConversion<string>()
    //         .HasMaxLength(20);
    // }
}