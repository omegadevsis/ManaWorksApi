using System.Text;
using ManaWorksUser.Application.Interfaces;
using ManaWorksUser.Application.Queries.Users;
using ManaWorksUser.Domain.Services;
using ManaWorksUser.Infrastructure.Persistence;
using ManaWorksUser.Infrastructure.Repositories;
using ManaWorksUser.Infrastructure.Messaging;
using ManaWorksUser.Infrastructure.Security;
using MediatorLib;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;


var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration["Connection:DefaultConnection"];
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseMySql(connection, ServerVersion.AutoDetect(connection)));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICriptographyService, CriptographyService>();
builder.Services.AddSingleton<UserCreatedPublisher>();

builder.Services.AddMediator(typeof(GetAllUsersQuery).Assembly);

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

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.MapControllers();
app.Urls.Add("http://*:5257");
app.Run();