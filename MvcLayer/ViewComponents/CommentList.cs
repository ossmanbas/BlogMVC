using Microsoft.AspNetCore.Mvc;
using MvcLayer.Models;
using System.Collections.Generic;

namespace MvcLayer.ViewComponents
{
    public class CommentList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>()
            {
                new UserComment()
                {
                    Id = 1,
                    Username = "Osman",

                },
                new UserComment()
                {
                    Id=2,
                    Username ="Memati",
                },
                new UserComment(){
                    Id=3,
                    Username ="Berkay",
                }};
            return View(commentValues);
        }
    }
}
