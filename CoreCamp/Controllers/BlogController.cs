using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCamp.Controllers
{
    public class BlogController : Controller
    {
        IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            var result = _blogService.GetWithCategoroy();
            return View(result);


        }
        public IActionResult BlogDetails(int id)
        {
            var result = _blogService.GetBlogDetail(id);
            return View(result);
        }

    }
}
