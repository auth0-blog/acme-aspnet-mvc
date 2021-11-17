using Microsoft.AspNetCore.Mvc;

namespace acme.Controllers;

public class CatalogController : Controller {
    private readonly ILogger<HomeController> _logger;

    public CatalogController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}