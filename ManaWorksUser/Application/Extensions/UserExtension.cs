using ManaWorksUser.Application.Dtos;
using ManaWorksUser.Domain.Entities;

namespace ManaWorksUser.Application.Extensions;

public static class UserExtension
{
    public static UserDto ToDto(this User user)
    {
        if (user == null) return null;

        return new UserDto
        {
            UserId = user.UserId,
            ProfileId = user.ProfileId,
            UserName = user.UserName,
            UserLogin = user.UserLogin,
            UserStatus = user.UserStatus,
            // Note que UserPassword geralmente não vai para DTO por segurança
        };
    }

    // Se precisar converter de DTO para entidade
    public static User ToEntity(this UserDto dto)
    {
        if (dto == null) return null;

        return new User(
            dto.UserId,
            dto.UserName,
            dto.UserLogin,
            "",
            0,
            dto.UserStatus
        );
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