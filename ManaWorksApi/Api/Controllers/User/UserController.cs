using ManaWorksApi.Application.Dtos;
using ManaWorksApi.Application.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace ManaWorksUser.Api.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class UserController : Controller
{
    private readonly IUserRepository _repository;

    public UserController(IUserRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult> Get(CancellationToken cancellationToken)
    {
        try
        {
            var result = await _repository.GetAllUsersAsync(cancellationToken);
            //var result = await _mediator.Send(new GetAllUsersQuery());
            //return Ok(result);
            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _repository.GetUserByIdAsync(id, cancellationToken);
            return result is not null ? Ok(result) : NotFound();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateUserDto command, CancellationToken cancellationToken)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                var result = await _repository.AddAsync(command, cancellationToken);
                //var result = await _mediator.Send(command);
                return Ok(result);
                
            }
        }
        catch (Exception e)
        {
            return Unauthorized();
        }
    }
    
    [HttpPut]
    public async Task<IActionResult> Put([FromBody] UserDto command,  CancellationToken cancellationToken)
    {
        try
        {
            var result = await _repository.UpdateAsync(command, cancellationToken);
            return Ok(result);
        }
        catch (Exception e)
        {
            return Unauthorized();
        }
    }
    
    [HttpPatch]
    public async Task<IActionResult> Patch(int id, string password,  CancellationToken cancellationToken)
    {
        try
        {
            await _repository.UpdatePasswordAsync(id, password, cancellationToken);
            return Ok(id);
        }
        catch (Exception e)
        {
            return Unauthorized();
        }
    }
    
    [HttpDelete]
    public async Task<IActionResult> Put(int id, CancellationToken cancellationToken)
    {
        try
        {
            await _repository.DeleteAsync(id, cancellationToken);
            return Ok(id);
        }
        catch (Exception e)
        {
            return Unauthorized();
        }
    }
}