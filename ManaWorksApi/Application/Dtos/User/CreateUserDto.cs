using ManaWorksApi.Application.Extensions;
using ManaWorksApi.Domain.Entities.User;

namespace ManaWorksApi.Application.Dtos;

public class CreateUserDto
{
    public int ProfileId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Login { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}