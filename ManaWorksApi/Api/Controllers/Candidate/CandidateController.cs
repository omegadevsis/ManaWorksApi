using ManaWorksApi.Application.Dtos.Candidates;
using ManaWorksApi.Application.Interfaces.Candidate;

using Microsoft.AspNetCore.Mvc;

namespace ManaWorksApi.Api.Controllers.Candidate;

[ApiController]
[Route("v1/[controller]")]
public class CandidateController : ControllerBase
{
    
    private readonly ICandidateRepository _repository;

    public CandidateController(ICandidateRepository repository)
    {
        _repository = repository;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        try
        {
            var result = await _repository.GetAllCandidates(cancellationToken);
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
        var result = await _repository.GetCandidateById(id, cancellationToken);
        return result is not null ? Ok(result) : NotFound();
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateCandidateDto command, CancellationToken cancellationToken)
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

    // [HttpPatch]
    // public async Task<IActionResult> Patch(int id, CancellationToken cancellationToken)
    // {
    //     try
    //     {
    //         var result = await _repository
    //         return Ok(result);
    //     }
    //     catch (Exception e)
    //     {
    //         return Unauthorized();
    //     }
    // }
}