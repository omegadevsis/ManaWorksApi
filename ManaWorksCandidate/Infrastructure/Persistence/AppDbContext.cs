using ManaWorksCandidate.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksCandidate.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    
    public DbSet<Candidate> candidates { get; set; }
    public DbSet<CandidateAddress> candidateaddresses { get; set; }
    public DbSet<CandidateContact> candidatecontacts { get; set; }
    public DbSet<CandidateCourse> candidatecourses { get; set; }
    public DbSet<CandidateDocument> candidatedocuments { get; set; }
    public DbSet<CandidateEducation> candidateeducations { get; set; }
    public DbSet<CandidateExperience> candidateexperiences { get; set; }
    public DbSet<CandidateObjective> candidateobjectives { get; set; }
    public DbSet<EducationType> educationtypes { get; set; }
}