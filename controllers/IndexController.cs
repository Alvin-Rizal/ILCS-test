using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ilcs_test_programmer.model;

namespace ilcs_test_programmer.Controllers;

public class IndexController : Controller {
    private readonly ILogger<IndexController> _logger;

    public IndexController(ILogger<IndexController> logger) {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}