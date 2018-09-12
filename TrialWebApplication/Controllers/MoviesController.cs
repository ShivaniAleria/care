using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrialWebApplication.Models;

namespace TrialWebApplication.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()  {Name = "Shrek!" };

            var customers = new List<Customer> {
               new Customer { Name ="Customer 1"},
               new Customer { Name = "Customer 2"}
           };

            var viewModel = new RandomMovieViewModel
            {

            }

            return View(movie);
            //return Content("hii");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home");
        }

        //public ActionResult Edit(int id) {
        //    return Content("id=" + id);
        //}

        //public ActionResult Index(int? PageIndex, string sortBy)
        //{
        //    if (!PageIndex.HasValue)
        //        PageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("PageIndex={0}&sortBy={1}",PageIndex,sortBy));

        //}

        [Route("movies/released/{year}/{month;regex(\\d{4}):range(1.12)}")]
        public ActionResult ByRealeaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}