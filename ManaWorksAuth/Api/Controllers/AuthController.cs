using ManaWorksApi.Application.Commands;
using ManaWorksAuth.Domain.Entities;
using MediatorLib;
using Microsoft.AspNetCore.Mvc;

namespace ManaWorksAuth.Api.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class AuthController : ControllerBase
{
    private readonly Mediator _mediator;

    public AuthController(Mediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> Post([FromBody] AuthCommand auth)
    {
        try
        {
            var user = new User(0, "", "", "", 0, "");
            var result = await _mediator.Send(auth);
            return Ok(result);
        }
        catch (Exception e)
        {
            //Console.WriteLine(e);
            //throw;
            return Unauthorized();
        }
    }
}