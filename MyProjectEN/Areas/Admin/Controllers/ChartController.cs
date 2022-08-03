using Microsoft.AspNetCore.Mvc;
using MyProjectEN.Areas.Admin.Models;
using System.Collections.Generic;

namespace MyProjectEN.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();

            list.Add(new CategoryClass
            {
                categoryname = "Gold",
                categorycount = 12
            });
            list.Add(new CategoryClass 
            {
                categoryname = "Silver",
                categorycount = 8
            });
            list.Add(new CategoryClass
            {
                categoryname = "Nasdaq",
                categorycount = 5
            });
            list.Add(new CategoryClass
            {
                categoryname = "Crypto",
                categorycount = 13
            });
            return Json(new { jsonlist = list });
        }
    }
}
