using System.Text;
using ManaWorksApi.Application.Commands;
using ManaWorksApi.Application.Handlers;
using ManaWorksApi.Domain.Services;
using ManaWorksAuth.Application.Dtos;
using ManaWorksAuth.Application.Interfaces;
using ManaWorksAuth.Domain.Entities;
using ManaWorksAuth.Infrastructure.Messaging;
using ManaWorksAuth.Infrastructure.Persistence;
using ManaWorksAuth.Infrastructure.Repositories;
using ManaWorksAuth.Infrastructure.Security;
using MediatorLib;
using MediatorLib.Requests;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure DbContext
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Register services
builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IEncryptionService, EncryptionService>();
builder.Services.AddScoped<IJwtService, JwtService>();

// Register Mediator and Handlers
builder.Services.AddSingleton<Mediator>();
builder.Services.AddScoped<IRequestHandler<AuthCommand, UserAuthResult>, AuthHandler>();

// Register Kafka Consumer
builder.Services.AddHostedService<UserCreatedConsumer>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.MapControllers();
app.Run();