using Microsoft.AspNetCore.Mvc;

namespace ManaWorksApi.Api.Controllers;

public class PermissaoController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}