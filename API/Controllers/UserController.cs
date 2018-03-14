using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Configuration;

namespace API.Controllers
{
    /// <summary>
    /// API for Location control
    /// </summary>
    public class UserController : ApiController
    {
        DeskShellEntities db = DatabaseEntityCreator.CreateDB();

        [HttpPost]
        [AllowAnonymous]
        [Route("api/register", Name = "Register")]
        [ResponseType(typeof(IHttpActionResult))]
        public IHttpActionResult Register(UserAuthentication user)
        {
            if (user == null || string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
                return BadRequest("Invalid User!");
            else if (db.Users.Where(x => x.Username.ToLower().Equals(user.Username)).FirstOrDefault() != null)
                return BadRequest("Username already exists!");

            try
            {
                var encryptedPassword = Crypto.EncryptString(user.Password);
                db.Users.Add(new User()
                {
                    Username = user.Username,
                    Password = encryptedPassword,
                    Created = DateTime.UtcNow,
                    LastLogin = null
                });
                db.SaveChanges();

                return Ok($"Succesfully Created New User {user.Username}.");
            }
            catch (Exception)
            {
                return BadRequest("Failed to create new user account!");
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/login", Name = "Login")]
        [ResponseType(typeof(string))]
        public IHttpActionResult Login(UserAuthentication user)
        {
            if (user == null || string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
                return BadRequest("Invalid Login");

            try
            {                               
                var existingUser = db.Users.Where(x => x.Username.ToLower().Equals(user.Username.ToLower())).FirstOrDefault();

                if (existingUser == null || !Crypto.CompareString(user.Password, existingUser.Password))
                    return BadRequest("Invalid Login");

                return Ok("Success!");
            }
            catch (Exception)
            {
                return BadRequest("Failed to Login");
            }
        }
    }
}