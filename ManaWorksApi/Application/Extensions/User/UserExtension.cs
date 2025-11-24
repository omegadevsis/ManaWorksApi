using ManaWorksApi.Application.Dtos;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Domain.Entities.User;

namespace ManaWorksApi.Application.Extensions;

public static class UserExtension
{
    public static UserDto ToDto(this User user)
    {
        if (user == null) return null;

        return new UserDto
        {
            UserId = user.UserId,
            ProfileId = user.ProfileId,
            Name = user.Name,
            Login = user.Login,
            Status = user.Status,
            // Note que UserPassword geralmente não vai para DTO por segurança
        };
    }

    // Se precisar converter de DTO para entidade
    public static User ToEntity(this UserDto dto)
    {
        if (dto == null) return null;

        return new User
        {
            UserId = dto.UserId,
            ProfileId = dto.ProfileId,
            Name = dto.Name,
            Login = dto.Login,
            Status = dto.Status,
        };
    }

    public static CreateUserDto ToCreateDto(this User user)
    {
        if (user == null) return null;
        return new CreateUserDto
        {
            ProfileId = user.ProfileId,
            Name = user.Name,
            Login = user.Login,
            Status = user.Status,
            Password =  user.Password,
            CreatedAt = user.CreatedAt,
        };
    }
    
    public static User ToCreateEntity(this CreateUserDto user)
    {
        if (user == null) return null;
        return new User
        {
            ProfileId = user.ProfileId,
            Name = user.Name,
            Login = user.Login,
            Status = user.Status,
            Password =  user.Password,
            CreatedAt = user.CreatedAt,
        };
    }
    
    public static List<UserDto> ToDtoList(this List<User> users)
    {
        if (users == null) return new List<UserDto>();

        var dtoList = new List<UserDto>(users.Count);
        foreach (var user in users)
        {
            dtoList.Add(user.ToDto());
        }
        return dtoList;
    }
}