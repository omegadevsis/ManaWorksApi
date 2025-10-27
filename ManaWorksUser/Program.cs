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
using MediatorLib;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration["Connection:DefaultConnection"];
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseMySql(connection, ServerVersion.AutoDetect(connection)));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICriptographyService, CriptographyService>();

builder.Services.AddMediator(typeof(GetAllUsersQuery).Assembly);
//builder.Services.AddSingleton<IMediator, Mediator>();
//builder.Services.AddTransient<IRequestHandler<GetAllUsersQuery, List<User>>, GetAllUsersHandler>();
//builder.Services.AddAutoMapper(cfg => {}, typeof(UserProfile));
//builder.Services.AddAutoMapper(cfg => cfg.CreateMap<User, UserDto>().ReverseMap());
//builder.Services.AddAutoMapper(typeof(UserProfile));

// var mediator = new MediatorBuilder().RegisterHandlers(typeof(GetAllUsersQuery).Assembly);
// builder.Services.RegisterMediator(mediator);


// builder.Services.AddMediatR(cfg => 
//     cfg.RegisterServicesFromAssemblies(
//         Assembly.GetExecutingAssembly(),
//         typeof(GetAllUsersQuery).Assembly,
//         typeof(GetUserByIdQuery).Assembly,
//         typeof(CreateUserCommand).Assembly,
//         typeof(UpdateUserCommand).Assembly,
//         typeof(DeleteUserCommand).Assembly,
//         typeof(User).Assembly)
//     );

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
