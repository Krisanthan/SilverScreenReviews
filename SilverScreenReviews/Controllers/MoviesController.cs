using SilverScreenReviews.Models;
using SilverScreenReviews.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SilverScreenReviews.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public ViewResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        // GET: Movies
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Interstellar", Id=1 };
        //    var users = new List<User>
        //    {
        //        new User {Name = "Todd"},
        //        new User {Name = "Rodd"}
        //    };

        //    var viewModel = new RandomMovieViewModel
        //    {
        //        Movie = movie,
        //        Users = users
        //    };

        //    return View(viewModel);
        //}

        //[Route("movies/released/{year:regex(\\d{4}):range(1990, 2018)}")]
        //public ActionResult ByReleaseDate(int year)
        //{
        //    return Content(year + "");
        //}

    }
}