using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverScreenReviews.DTO
{
    public class ReviewDTO
    {
        public int UserID { get; set; }
        public List<int> MovieIds { get; set; }
    }
}