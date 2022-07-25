using Microsoft.AspNetCore.Mvc;

namespace MyProjectEN.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
