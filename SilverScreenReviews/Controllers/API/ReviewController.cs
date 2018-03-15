using SilverScreenReviews.DTO;
using SilverScreenReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SilverScreenReviews.Controllers.API
{
    public class ReviewController : ApiController
    {
        private ApplicationDbContext _context;

        public ReviewController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewReviews(ReviewDTO newReview)
        {
            var user = _context.Users.Single(
                c => c.Id == newReview.UserID);

            var movies = _context.Movies.Where(
                m => newReview.MovieIds.Contains(m.Id));

            foreach (var movie in movies)
            {
                var review = new Review
                {
                    User = user,
                    Movie = movie,
                    DateReviewed = DateTime.Now
                };

                _context.Reviews.Add(review);
            }

            _context.SaveChanges();
            return Ok();
        }
    }
}