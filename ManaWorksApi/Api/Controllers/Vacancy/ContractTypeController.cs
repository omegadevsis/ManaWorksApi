using ManaWorksApi.Application.Dtos.ContractTypes;
using ManaWorksApi.Application.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace ManaWorksApi.Api.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class ContractTypeController : ControllerBase
{
    private readonly IContractTypeRepository _repository;

    public ContractTypeController(IContractTypeRepository repository)
    {
        _repository = repository;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        try
        {
            var result = await _repository.GetContractTypes(cancellationToken);
            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id,CancellationToken cancellationToken)
    {
        var result = await _repository.GetContractTypesByIdAsync(id, cancellationToken);
        return result is not null ? Ok(result) : NotFound();
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateContractTypeDto command, CancellationToken cancellationToken)
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