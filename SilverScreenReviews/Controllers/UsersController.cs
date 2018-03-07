using SilverScreenReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SilverScreenReviews.ViewModels;

namespace SilverScreenReviews.Controllers
{
    public class UsersController : Controller
    {
        private ApplicationDbContext _context;

        public UsersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Users
        public ViewResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var user = _context.Users.SingleOrDefault(c => c.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel 
            {
                User = new User(),
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(User user)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    User = user,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("CustomerForm", viewModel);
            }
            if(user.Id == 0)
                _context.Users.Add(user);
            else
            {
                var userInDb = _context.Users.Single(c => c.Id == user.Id);

                userInDb.Name = user.Name;
                userInDb.premiumStatus = user.premiumStatus;
                userInDb.MembershipTypeId = user.MembershipTypeId;
                userInDb.MembershipType = user.MembershipType;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Users");
        }

        public ActionResult Edit(int id)
        {
            var user = _context.Users.SingleOrDefault(c => c.Id == id);
            if (user == null)
                return HttpNotFound();
            var viewModel = new CustomerFormViewModel
            {
                User = user,
                MembershipTypes = _context.MembershipTypes.ToList()
            }; 
            return View("CustomerForm", viewModel);
        }
    }
}