
using ManaWorksApi.Application.Extensions;

namespace ManaWorksApi.Application.Dtos;

public class UserDto
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public int ProfileId { get; set; }
    public string Status { get; set; }
}