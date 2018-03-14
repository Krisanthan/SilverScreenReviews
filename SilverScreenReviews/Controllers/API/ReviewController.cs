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

        public IHttpActionResult CreateNewReview(ReviewDTO reviewDTO)
        {
            throw new NotImplementedException();
        }
    }
}