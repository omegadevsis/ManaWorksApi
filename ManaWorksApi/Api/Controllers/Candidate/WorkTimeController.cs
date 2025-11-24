using ManaWorksApi.Application.Interfaces.Candidate;
using Microsoft.AspNetCore.Mvc;

namespace ManaWorksApi.Api.Controllers.Candidate;

[ApiController]
[Route("v1/[controller]")]
public class WorkTimeController : ControllerBase
{
    // GET
    private readonly IWorkTimeRepository _repository;

    public WorkTimeController(IWorkTimeRepository repository)
    {
        _repository = repository;
    }
    
    // GET
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        try
        {
            var result = await _repository.GetAllWorkTimes(cancellationToken);
            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}