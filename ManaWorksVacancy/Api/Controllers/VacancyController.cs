using ManaWorksVacancy.Application.Commands.Vacancies;
using ManaWorksVacancy.Application.Queries.Vacancies;
using MediatorLib;
using Microsoft.AspNetCore.Mvc;

namespace ManaWorksVacancy.Api.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class VacancyController : ControllerBase
{
    private readonly Mediator _mediator;

    public VacancyController(Mediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get(string status)
    {
        try
        {
            var result = await _mediator.Send(new GetAllVacanciesQuery(status));
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
        var result = await _mediator.Send(new GetVacancyByIdQuery(id));
        return result is not null ? Ok(result) : NotFound();
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateVacancyCommand command)
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
    public async Task<IActionResult> Put([FromBody] UpdateVacancyCommand command)
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
            var result = await _mediator.Send(new DeleteVacancyCommand(id));
            return Ok(result);
        }
        catch (Exception e)
        {
            return Unauthorized();
        }
    }

    [HttpPatch]
    public async Task<IActionResult> Patch(int id)
    {
        try
        {
            var result = await _mediator.Send(new DisableVacancyCommand(id));
            return Ok(result);
        }
        catch (Exception e)
        {
            return Unauthorized();
        }
    }
}