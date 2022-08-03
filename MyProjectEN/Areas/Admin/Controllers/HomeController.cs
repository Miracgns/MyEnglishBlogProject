using Microsoft.AspNetCore.Mvc;

namespace MyProjectEN.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
 