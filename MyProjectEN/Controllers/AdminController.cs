using Microsoft.AspNetCore.Mvc;

namespace MyProjectEN.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
