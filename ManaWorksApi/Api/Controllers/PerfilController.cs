using Microsoft.AspNetCore.Mvc;

namespace ManaWorksApi.Api.Controllers;

public class PerfilController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}