using Microsoft.AspNetCore.Mvc;

namespace MyProjectEN.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
