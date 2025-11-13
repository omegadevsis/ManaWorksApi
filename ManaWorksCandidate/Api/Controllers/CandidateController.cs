using ManaWorksCandidate.Application.Commands.Candidates;
using ManaWorksCandidate.Application.Dtos.Candidates;
using ManaWorksCandidate.Application.Queries.Candidates;
using MediatorLib;
using Microsoft.AspNetCore.Mvc;

namespace ManaWorksCandidate.Api.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class CandidateController : ControllerBase
{
    private readonly Mediator _mediator;

    public CandidateController(Mediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get(string status, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _mediator.Send(new GetAllCandidatesQuery(status), cancellationToken);
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
        var result = await _mediator.Send(new GetCandidateByIdQuery(id), cancellationToken);
        return result is not null ? Ok(result) : NotFound();
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateCandidateCommand command, CancellationToken cancellationToken)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                var result = await _mediator.Send(command, cancellationToken);
                return Ok(result);
                
            }
        }
        catch (Exception e)
        {
            return Unauthorized();
        }
    }

    [HttpPatch]
    public async Task<IActionResult> Patch(int id, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _mediator.Send(new DisableCandidateCommand(id), cancellationToken);
            return Ok(result);
        }
        catch (Exception e)
        {
            return Unauthorized();
        }
    }
}