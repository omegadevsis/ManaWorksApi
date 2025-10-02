using ManaWorksApi.Application.Commands.Login;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Infrastructure.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ManaWorksApi.Api.Controllers;

[Route("v1/manaworks")]
public class LoginController : Controller
{
    private readonly IMediator _mediator;

    public LoginController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> Post([FromBody] LoginCommand login)
    {
        try
        {
            var result = await _mediator.Send(login);
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