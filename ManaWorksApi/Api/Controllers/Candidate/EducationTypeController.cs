
using ManaWorksApi.Application.Dtos.Educations;
using ManaWorksApi.Application.Interfaces.Candidate;

using Microsoft.AspNetCore.Mvc;

namespace ManaWorksApi.Api.Controllers.Candidate;

[ApiController]
[Route("v1/[controller]")]
public class EducationTypeController : ControllerBase
{
    private readonly IEducationTypeRepository _repository;

    public EducationTypeController(IEducationTypeRepository repository)
    {
        _repository = repository;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        try
        {
            var result = await _repository.GetAllEducationTypes(cancellationToken);
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
        var result = await _repository.GetEducationTypeById(id, cancellationToken);
        return result is not null ? Ok(result) : NotFound();
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateEducationTypeDto command, CancellationToken cancellationToken)
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
                return Ok(result);
            }
        }
        catch (Exception e)
        {
            return Unauthorized();
        }
    }
}