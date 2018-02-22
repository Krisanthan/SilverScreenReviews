using SilverScreenReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SilverScreenReviews.Controllers.API
{
    public class UsersController : ApiController
    {
        private ApplicationDbContext _context;

        public UsersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/users
        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        // GET /api/user/1
        public User GetUser(int id)
        {
            var user = _context.Users.SingleOrDefault(c => c.Id == id);
            if (user == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return user;
        }

        // POST /api/users
        [HttpPost]
        public User CreateUser(User user)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        } 

        // PUT /api/users/1
        [HttpPut]
        public void UpdateUser(int id, User user)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var userInDb = _context.Users.SingleOrDefault(c => c.Id == id);

            if (userInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            userInDb.Name = user.Name;
            userInDb.MembershipTypeId = user.MembershipTypeId;
            userInDb.premiumStatus = user.premiumStatus;
            userInDb.MembershipType = user.MembershipType;

            _context.SaveChanges();
        }

        // DELETE /api/customers/1
        [HttpDelete]
        public void DeleteUser(int id)
        {
            var userInDb = _context.Users.SingleOrDefault(c => c.Id == id);

            if (userInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Users.Remove(userInDb);
            _context.SaveChanges();
        }
    }
}
