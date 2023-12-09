using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Logging;
using MvC5Course.Models;

namespace MvC5Course.Controllers
{
    public class MovieController : Controller
    {
        private readonly ILogger<MovieController> _logger;

        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            var Movie = new Movies{Name = " Carl" };
            return View(Movie);
            // return Content(" Helleo");
            // return new EmptyResult();
            // return RedirectToAction("Index","Home" ,new {Page = 1 ,SortBy = "name"} );
        }

        public IActionResult Edith(int id)
        {
            return Content("Id=" + id);
        }

        //movies
        public IActionResult List(int? pageIndex , string SortBy)
        {
            if (!pageIndex.HasValue)
            pageIndex = 1;
            if (string.IsNullOrWhiteSpace(SortBy))
                SortBy = "Name";
            return Content(string.Format("pageIndex={0}&SortBy={1}",pageIndex , SortBy));
        }
            
      
    }
}