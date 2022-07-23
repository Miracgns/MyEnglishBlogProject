using Microsoft.AspNetCore.Mvc;

namespace MyProjectEN.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
