using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EspacoVerde.Models;
using System.Net.NetworkInformation;
using EspacoVerde.Data;
using Microsoft.EntityFrameworkCore;

namespace EspacoVerde.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        // Buscar resíduos com os dados do usuário dono e transação (se houver)
        var residuos = _context.Residuos
            .Include(r => r.Usuario)
            .Include(r => r.Transacao)
            .Include(r => r.Localizacao)
            .ToList();

        return View(residuos);
    }

    public IActionResult SobreNos()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
