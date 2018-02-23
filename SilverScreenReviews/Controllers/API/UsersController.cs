using AutoMapper;
using SilverScreenReviews.DTO;
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
        public IEnumerable<UserDTO> GetUsers()
        {
            return _context.Users.ToList().Select(Mapper.Map<User, UserDTO>);
        }

        // GET /api/user/1
        public UserDTO GetUser(int id)
        {
            var user = _context.Users.SingleOrDefault(c => c.Id == id);
            if (user == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<User, UserDTO>(user);
        }

        // POST /api/users
        [HttpPost]
        public UserDTO CreateUser(UserDTO userDTO)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var user = Mapper.Map<UserDTO, User>(userDTO);
            _context.Users.Add(user);
            _context.SaveChanges();

            userDTO.Id = user.Id;

            return userDTO;
        } 

        // PUT /api/users/1
        [HttpPut]
        public void UpdateUser(int id, UserDTO userDTO)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var userInDb = _context.Users.SingleOrDefault(c => c.Id == id);

            if (userInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(userDTO, userInDb);

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
