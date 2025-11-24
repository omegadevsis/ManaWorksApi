using ManaWorksApi.Application.Interfaces.Candidate;
using Microsoft.AspNetCore.Mvc;

namespace ManaWorksApi.Api.Controllers.Candidate;

[ApiController]
[Route("v1/[controller]")]
public class MaritalController : Controller
{
    private readonly IMaritalRepository _repository;

    public MaritalController(IMaritalRepository repository)
    {
        _repository = repository;
    }
    
    // GET
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        try
        {
            var result = await _repository.GetAllMaritals(cancellationToken);
            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}