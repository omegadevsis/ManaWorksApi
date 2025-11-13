using System.Text;
using ManaWorksApi.Api.Configuration;
using ManaWorksApi.Application.Commands.Login;
using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Services;
using ManaWorksApi.Infrastructure.Persistence;
using ManaWorksApi.Infrastructure.Repositories;
using ManaWorksApi.Infrastructure.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;


var builder = WebApplication.CreateBuilder(args);

var Conexao = builder.Configuration["Connection:DefaultConnection"];
var ConexaoHR = builder.Configuration["ConnectionHr:DefaultConnectionHr"];
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseMySql(Conexao, ServerVersion.AutoDetect(Conexao)));

builder.Services.AddScoped<ILoginRepository, LoginRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IPerfilRepository, PerfilRepository>();
builder.Services.AddScoped<ICriptografiaService, CriptografiaService>();
builder.Services.AddScoped<IJwtService, JwtService>();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(LoginCommand).Assembly));

builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));

//var secretKey = Environment.GetEnvironmentVariable("JWT_SECRET_KEY");
var secretKey = "ZNIAatlQQbcd9vl97FHlZ1GPmq0K1h01ysRQnOF2Oko=";
if (!string.IsNullOrEmpty(secretKey))
{
    builder.Services.PostConfigure<JwtSettings>(options =>
    {
        options.SecretKey = secretKey;
    });
}

builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer("Bearer", options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["Jwt:SecretKey"]))
        };
    });

builder.Services.AddAuthorization();




// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
//app.UseHttpsRedirection();
app.Run();
