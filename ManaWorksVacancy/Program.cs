using System.Text;
using ManaWorksVacancy.Application.Interfaces;
using ManaWorksVacancy.Application.Queries.ContractTypes;
using ManaWorksVacancy.Application.Queries.JourneyTypes;
using ManaWorksVacancy.Application.Queries.Vacancies;
using ManaWorksVacancy.Application.Queries.WorkTypes;
using ManaWorksVacancy.Infrastructure.Persistence;
using ManaWorksVacancy.Infrastructure.Repositories;
using ManaWorksVacancy.Infrastructure.Security;
using MediatorLib;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connection = builder.Configuration["Connection:DefaultConnection"];
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseMySql(connection, ServerVersion.AutoDetect(connection)));

builder.Services.AddScoped<IVacancyRepository, VacancyRepository>();
builder.Services.AddScoped<IJourneyTypeRepository, JourneyTypeRepository>();
builder.Services.AddScoped<IWorkTypeRepository, WorkTypeRepository>();
builder.Services.AddScoped<IContractTypeRepository, ContractTypeRepository>();

builder.Services.AddMediator(typeof(GetAllVacanciesQuery).Assembly);
builder.Services.AddMediator(typeof(GetVacancyByIdQuery).Assembly);
builder.Services.AddMediator(typeof(GetAllContractTypesQuery).Assembly);
builder.Services.AddMediator(typeof(GetContractTypeByIdQuery).Assembly);
builder.Services.AddMediator(typeof(GetAllJourneyTypesQuery).Assembly);
builder.Services.AddMediator(typeof(GetJourneyTypeByIdQuery).Assembly);
builder.Services.AddMediator(typeof(GetAllWorkTypesQuery).Assembly);
builder.Services.AddMediator(typeof(GetWorkTypeByIdQuery).Assembly);

var key = Encoding.ASCII.GetBytes(Settings.Secret);
builder.Services.AddAuthentication(x =>
    {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(x =>
    {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false
        };
        x.Events = new JwtBearerEvents
        {
            OnAuthenticationFailed = context =>
            {
                if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                {
                    context.Response.Headers.Add("Token-Expired", "true");
                }

                return Task.CompletedTask;
            }
        };
    });

builder.Services.AddAuthorization();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Urls.Add("http://*:5233");

app.Run();