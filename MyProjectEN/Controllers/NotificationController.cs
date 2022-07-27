using Microsoft.AspNetCore.Mvc;

namespace MyProjectEN.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
