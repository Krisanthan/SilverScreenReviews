using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverScreenReviews.ViewModels
{
    public class MovieViewFormModel
    {
        public IEnumerable<genre> Genres { get; set; }
    }
}