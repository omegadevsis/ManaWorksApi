using System.Reflection;
using ManaWorksUser.Application.Commands.Users;
using ManaWorksUser.Application.Dtos;
using ManaWorksUser.Application.Handlers.UserHandler;
using ManaWorksUser.Application.Interfaces;
using ManaWorksUser.Application.Queries.Users;
using ManaWorksUser.Domain.Entities;
using ManaWorksUser.Domain.Services;
using ManaWorksUser.Infrastructure.Persistence;
using ManaWorksUser.Infrastructure.Repositories;
using ManaWorksUser.Infrastructure.Messaging;
using MediatorLib;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration["Connection:DefaultConnection"];
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseMySql(connection, ServerVersion.AutoDetect(connection)));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICriptographyService, CriptographyService>();
builder.Services.AddSingleton<UserCreatedPublisher>();

builder.Services.AddMediator(typeof(GetAllUsersQuery).Assembly);

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
app.Run();