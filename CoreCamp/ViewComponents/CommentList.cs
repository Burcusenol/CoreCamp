using CoreCamp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCamp.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var result = new List<UserComment>
            {
                new UserComment
                {
                    Id=1,
                     UserName="Burcu"
                },
                new UserComment
                {
                    Id=2,
                     UserName="Şenol"
                }
            };
            return View(result);
        }
    }
}
