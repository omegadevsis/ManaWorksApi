using ManaWorksApi.Application.Dtos.Auth;
using ManaWorksApi.Application.Interfaces.Auth;
using Microsoft.AspNetCore.Mvc;

namespace ManaWorksApi.Api.Controllers.Auth;

[ApiController]
[Route("v1/[controller]")]
public class AuthController : ControllerBase
{
    
    private readonly IAuthRepository _repository;

    public AuthController(IAuthRepository repository)
    {
        _repository = repository;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get(string status, CancellationToken cancellationToken)
    {
        try
        {
            return Ok("Api ok");
        }
        catch (Exception e)
        {
            return Unauthorized();
        }
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] UserAuth auth, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _repository.GetUser(auth.Login, auth.Password);
            return Ok(result);
        }
        catch (Exception e)
        {
            return Unauthorized();
        }
    }
}