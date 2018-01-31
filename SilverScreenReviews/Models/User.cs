using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverScreenReviews.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool premiumStatus { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}