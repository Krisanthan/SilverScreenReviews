using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SilverScreenReviews.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Full name")]
        public string Name { get; set; }

        [ValidAge]
        public bool premiumStatus { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}