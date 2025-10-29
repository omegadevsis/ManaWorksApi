using ManaWorksUser.Application.Commands.Users;
using ManaWorksUser.Application.Extensions;
using ManaWorksUser.Application.Queries.Users;
using MediatorLib;
using Microsoft.AspNetCore.Mvc;

namespace ManaWorksUser.Api.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class UserController : ControllerBase
{
    private readonly Mediator _mediator;

    public UserController(Mediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var result = await _mediator.Send(new GetAllUsersQuery());
            //return Ok(result);
            return Ok(result.ToDtoList());
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetUserByIdQuery(id));
        return result is not null ? Ok(result.ToDto()) : NotFound();
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateUserCommand command)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                var result = await _mediator.Send(command);
                return Ok(result);
                
            }
        }
        catch (Exception e)
        {
            return Unauthorized();
        }
    }
    
    [HttpPut]
    public async Task<IActionResult> Put([FromBody] UpdateUserCommand command)
    {
        try
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        catch (Exception e)
        {
            return Unauthorized();
        }
    }
    
    [HttpDelete]
    public async Task<IActionResult> Put(int id)
    {
        try
        {
            var result = await _mediator.Send(new DeleteUserCommand(id));
            return Ok(result);
        }
        catch (Exception e)
        {
            return Unauthorized();
        }
    }
}