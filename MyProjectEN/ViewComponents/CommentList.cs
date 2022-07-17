using Microsoft.AspNetCore.Mvc;
using MyProjectEN.Models;
using System.Collections.Generic;

namespace MyProjectEN.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    Username="Miraç"
                },
                new UserComment
                {
                    ID=2,
                    Username="Efe"
                },
                new UserComment
                {
                    ID=3,
                    Username="Ahmet"
                }

            };
            return View(commentvalues);
        }   
    }
}
