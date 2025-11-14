using ManaWorksAuth.Application.Commands;
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
    
    [HttpGet]
    public async Task<IActionResult> Get(string status)
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
    public async Task<IActionResult> Post([FromBody] AuthCommand auth)
    {
        try
        {
            var result = await _mediator.Send(auth);
            return Ok(result);
        }
        catch (Exception e)
        {
            return Unauthorized();
        }
    }
}