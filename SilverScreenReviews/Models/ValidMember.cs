﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SilverScreenReviews.Models
{
    public class ValidMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var user = (User)validationContext.ObjectInstance;

            if (user.MembershipTypeId == MembershipType.Free)
                return ValidationResult.Success;
            else if (user.premiumStatus == false)
                return new ValidationResult("Must be a premium member");

            return ValidationResult.Success;
        }
    }
}