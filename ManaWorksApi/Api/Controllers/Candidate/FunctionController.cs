using ManaWorksApi.Application.Interfaces.Candidate;
using Microsoft.AspNetCore.Mvc;

namespace ManaWorksApi.Api.Controllers.Candidate;

[ApiController]
[Route("v1/[controller]")]
public class FunctionController : Controller
{
    private readonly IFunctionRepository _repository;

    public FunctionController(IFunctionRepository repository)
    {
        _repository = repository;
    }
    
    // GET
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        try
        {
            var result = await _repository.GetAllFunctions(cancellationToken);
            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}