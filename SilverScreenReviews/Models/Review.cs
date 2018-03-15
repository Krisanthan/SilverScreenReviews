using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SilverScreenReviews.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        public User User { get; set; }
        
        [Required]
        public Movie Movie { get; set; }

        public int rating { get; set; }

        public DateTime DateReviewed { get; set; }
    }
}