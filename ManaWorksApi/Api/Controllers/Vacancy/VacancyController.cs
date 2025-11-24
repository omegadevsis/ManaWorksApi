using ManaWorksApi.Application.Dtos.Vacancies;
using ManaWorksApi.Application.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace ManaWorksApi.Api.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class VacancyController : ControllerBase
{
    private readonly IVacancyRepository _repository;

    public VacancyController(IVacancyRepository repository)
    {
        _repository = repository;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get(string status, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _repository.GetVacancies(status, cancellationToken);
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
        var result = await _repository.GetVacancyByIdAsync(id, cancellationToken);
        return result is not null ? Ok(result) : NotFound();
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateVacancyDto command, CancellationToken cancellationToken)
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
    
    [HttpPut]
    public async Task<IActionResult> Put([FromBody] UpdateVacancyDto command, CancellationToken cancellationToken)
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

    // [HttpPatch]
    // public async Task<IActionResult> Patch(int id, CancellationToken cancellationToken)
    // {
    //     try
    //     {
    //         //var result = await await _repository.UpdateAsync(id, cancellationToken);
    //         return Ok(id);
    //     }
    //     catch (Exception e)
    //     {
    //         return Unauthorized();
    //     }
    // }
}