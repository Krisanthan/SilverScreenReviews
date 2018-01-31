using SilverScreenReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SilverScreenReviews.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ViewResult Index()
        {
            var users = listUsers();
            return View(users);
        }

        private IEnumerable<User> listUsers()
        {
            var user1 = new User() { Name = "Tom Hamen", Id = 1 };
            var user2 = new User() { Name = "Vally Pop", Id = 2 };
            List<User> users = new List<User> { user1, user2 };
            return users;
        }

        public ActionResult Details(int id)
        {
            var user = listUsers().SingleOrDefault(c => c.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }
    }
}