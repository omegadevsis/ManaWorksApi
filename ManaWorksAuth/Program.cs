using ManaWorksAuth.Api.Configuration;
using ManaWorksAuth.Application.Commands;
using ManaWorksAuth.Application.Interfaces;
using ManaWorksAuth.Domain.Services;
using ManaWorksAuth.Infrastructure.Persistence;
using ManaWorksAuth.Infrastructure.Repositories;
using ManaWorksAuth.Infrastructure.Security;
using MediatorLib;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

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
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));

// Register Mediator and Handlers
builder.Services.AddMediator(typeof(AuthCommand).Assembly);

// Register RabbitMQ Consumer
//builder.Services.AddHostedService<UserCreatedConsumer>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseCors("AllowOrigin");
app.MapControllers();
app.Urls.Add("http://*:5214");
app.Run();