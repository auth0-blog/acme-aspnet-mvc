using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace acme.Controllers;

public class CatalogController : Controller {
    private readonly ILogger<HomeController> _logger;

    public CatalogController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [Authorize]
    public IActionResult Index()
    {
        return View();
    }
}