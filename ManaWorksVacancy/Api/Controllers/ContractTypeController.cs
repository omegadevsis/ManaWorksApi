using ManaWorksVacancy.Application.Commands.ContractTypes;
using ManaWorksVacancy.Application.Commands.WorkTypes;
using ManaWorksVacancy.Application.Queries.ContractTypes;
using ManaWorksVacancy.Application.Queries.WorkTypes;
using MediatorLib;
using Microsoft.AspNetCore.Mvc;

namespace ManaWorksVacancy.Api.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class ContractTypeController : ControllerBase
{
    private readonly Mediator _mediator;

    public ContractTypeController(Mediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var result = await _mediator.Send(new GetAllContractTypesQuery());
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
        var result = await _mediator.Send(new GetContractTypeByIdQuery(id));
        return result is not null ? Ok(result) : NotFound();
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateContractTypeCommand command)
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