using ManaWorksCandidate.Application.Commands.EducationTypes;
using ManaWorksCandidate.Application.Queries.EducationTypes;
using MediatorLib;
using Microsoft.AspNetCore.Mvc;

namespace ManaWorksCandidate.Api.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class EducationTypeController : ControllerBase
{
    private readonly Mediator _mediator;

    public EducationTypeController(Mediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var result = await _mediator.Send(new GetAllEducationTypesQuery());
            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetEducationTypeByIdQuery(id));
        return result is not null ? Ok(result) : NotFound();
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateEducationTypeCommand command)
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
}