using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            return View(movie);
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home",new { page = 1, sortby = "name"});
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);

        }

        //movies
        public ActionResult Index(int? pageIndex, string sortby)
        {

            if (pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortby))
                sortby = "Name";

            return Content(String.Format("PageIndex={0}&sortBy={1}", pageIndex, sortby));
        }
    }
}