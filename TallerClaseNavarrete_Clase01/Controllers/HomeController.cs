using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TallerClaseNavarrete_Clase01.Models;
using TallerClaseNavarrete_Clase01.Repositories;

namespace TallerClaseNavarrete_Clase01.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        GeminiRepository repo = new GeminiRepository();
        string answer = await repo.GetChatbotResponse("Dame un resumen de la pelicula Titanic");
        return View(answer);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
