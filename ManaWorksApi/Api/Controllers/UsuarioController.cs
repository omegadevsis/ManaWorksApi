using ManaWorksApi.Application.Commands.Login;
using ManaWorksApi.Application.Commands.Usuarios;
using ManaWorksApi.Application.Queries.Usuarios;
using ManaWorksApi.Infrastructure.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ManaWorksApi.Api.Controllers;

[Route("v1/manaworks")]
public class UsuarioController : Controller
{
    private readonly IMediator _mediator;

    public UsuarioController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    [Route("usuario")]
    public async Task<IActionResult> Get()
    {
        try
        {
            var result = await _mediator.Send(new GetAllUsuariosQuery());
            return Ok(result);
        }
        catch (Exception e)
        {
            //Console.WriteLine(e);
            //throw;
            return Unauthorized();
        }
    }
    
    [HttpPost]
    [Route("usuario")]
    public async Task<IActionResult> Post([FromBody] CreateUsuarioCommand command)
    {
        try
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        catch (Exception e)
        {
            //Console.WriteLine(e);
            //throw;
            return Unauthorized();
        }
    }
    
    [HttpPut]
    [Route("usuario")]
    public async Task<IActionResult> Put([FromBody] UpdateUsuarioCommand command)
    {
        try
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        catch (Exception e)
        {
            //Console.WriteLine(e);
            //throw;
            return Unauthorized();
        }
    }
    
    [HttpPatch]
    [Route("usuario")]
    public async Task<IActionResult> Patch(int id, string senha)
    {
        try
        {
            var result = await _mediator.Send(new ChangeUsuarioPasswordCommand(id, senha));
            return NoContent();
        }
        catch (Exception e)
        {
            //Console.WriteLine(e);
            //throw;
            return Unauthorized();
        }
    }
    
    [HttpDelete]
    [Route("usuario")]
    public async Task<IActionResult> Put(int id)
    {
        try
        {
            var result = await _mediator.Send(new DeleteUsuarioCommand(id));
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