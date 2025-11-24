using System.Text;
using ManaWorksApi.Api.Configuration;

using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Application.Interfaces.Auth;
using ManaWorksApi.Application.Interfaces.Candidate;

using ManaWorksApi.Domain.Services;
using ManaWorksApi.Infrastructure.Persistence;
using ManaWorksApi.Infrastructure.Repositories;
using ManaWorksApi.Infrastructure.Repositories.Auth;
using ManaWorksApi.Infrastructure.Repositories.Candidate;
using ManaWorksApi.Infrastructure.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;


var builder = WebApplication.CreateBuilder(args);

// builder.WebHost.ConfigureKestrel(opt =>
// {
//     opt.ListenAnyIP(7205, listen =>
//     {
//         listen.UseHttps("certificado.pfx","");
//     });
// });

var urlAll = builder.Configuration["Origin:UrlAll"];
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin", builder =>
    {
        builder
            .WithOrigins(urlAll)
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var Conexao = builder.Configuration["Connection:DefaultConnection"];
var ConexaoHR = builder.Configuration["ConnectionHr:DefaultConnectionHr"];
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseMySql(Conexao, ServerVersion.AutoDetect(Conexao)));

//builder.Services.AddScoped<IJwtService, JwtService>();

builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IEncryptionService, EncryptionService>();
builder.Services.AddScoped<IJwtService, JwtService>();
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
builder.Services.AddScoped<IAuthRepository, AuthRepository>();

builder.Services.AddScoped<ICandidateRepository, CandidateRepository>();
builder.Services.AddScoped<IEducationTypeRepository, EducationTypeRepository>();
builder.Services.AddScoped<IWorkTimeRepository, WorkTimeRepository>();
builder.Services.AddScoped<IVacancyRepository, VacancyRepository>();
builder.Services.AddScoped<IJourneyTypeRepository, JourneyTypeRepository>();
builder.Services.AddScoped<IWorkTypeRepository, WorkTypeRepository>();
builder.Services.AddScoped<IContractTypeRepository, ContractTypeRepository>();
builder.Services.AddScoped<IFunctionRepository, FunctionRepository>();
builder.Services.AddScoped<IMaritalRepository, MaritalRepository>();
builder.Services.AddScoped<IExperienceTimeRepository, ExperienceTimeRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();

// builder.Services.AddMediator(typeof(AuthCommand).Assembly);
//
// builder.Services.AddMediator(typeof(GetAllVacanciesQuery).Assembly);
// builder.Services.AddMediator(typeof(GetVacancyByIdQuery).Assembly);
// builder.Services.AddMediator(typeof(GetAllContractTypesQuery).Assembly);
// builder.Services.AddMediator(typeof(GetContractTypeByIdQuery).Assembly);
// builder.Services.AddMediator(typeof(GetAllJourneyTypesQuery).Assembly);
// builder.Services.AddMediator(typeof(GetJourneyTypeByIdQuery).Assembly);
// builder.Services.AddMediator(typeof(GetAllWorkTypesQuery).Assembly);
// builder.Services.AddMediator(typeof(GetWorkTypeByIdQuery).Assembly);
//
// builder.Services.AddMediator(typeof(CreateWorkTypeCommand).Assembly);
// builder.Services.AddMediator(typeof(CreateJourneyTypeCommand).Assembly);
// builder.Services.AddMediator(typeof(CreateContractTypeCommand).Assembly);
//
// builder.Services.AddMediator(typeof(CreateVacancyCommand).Assembly);
//
// builder.Services.AddMediator(typeof(CreateEducationTypeCommand).Assembly);
//
// builder.Services.AddMediator(typeof(GetAllCandidatesQuery).Assembly);
// builder.Services.AddMediator(typeof(GetAllEducationTypesQuery).Assembly);
// builder.Services.AddMediator(typeof(CreateCandidateCommand).Assembly);
// builder.Services.AddMediator(typeof(DisableCandidateCommand).Assembly);
//
// builder.Services.AddMediator(typeof(CreateUserCommand).Assembly);
// builder.Services.AddMediator(typeof(DeleteUserCommand).Assembly);
// builder.Services.AddMediator(typeof(UpdateUserCommand).Assembly);
// builder.Services.AddMediator(typeof(GetAllUsersQuery).Assembly);
// builder.Services.AddMediator(typeof(GetUserByIdQuery).Assembly);

builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer("Bearer", options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
            ValidAudience = builder.Configuration["JwtSettings:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:SecretKey"]))
        };
    });

builder.Services.AddAuthorization();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();
app.MapControllers();
app.UseCors("AllowOrigin");
app.Urls.Add("http://*:5293");
//app.Urls.Add("https://*:5294");
//app.UseHttpsRedirection();
app.Run();
