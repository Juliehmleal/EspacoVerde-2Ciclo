using Microsoft.AspNetCore.Mvc;

namespace EspacoVerde.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
