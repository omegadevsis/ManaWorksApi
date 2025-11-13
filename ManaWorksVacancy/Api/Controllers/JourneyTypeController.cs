using ManaWorksVacancy.Application.Commands.JourneyTypes;
using ManaWorksVacancy.Application.Commands.Vacancies;
using ManaWorksVacancy.Application.Queries.JourneyTypes;
using ManaWorksVacancy.Application.Queries.Vacancies;
using MediatorLib;
using Microsoft.AspNetCore.Mvc;

namespace ManaWorksVacancy.Api.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class JourneyTypeController : ControllerBase
{
    private readonly Mediator _mediator;

    public JourneyTypeController(Mediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var result = await _mediator.Send(new GetAllJourneyTypesQuery());
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
        var result = await _mediator.Send(new GetJourneyTypeByIdQuery(id));
        return result is not null ? Ok(result) : NotFound();
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateJourneyTypeCommand command)
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