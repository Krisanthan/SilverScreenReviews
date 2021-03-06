﻿using SilverScreenReviews.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SilverScreenReviews.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public MembershipTypeDTO MembershipType { get; set; }

        //[ValidMember]
        public bool premiumStatus { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}