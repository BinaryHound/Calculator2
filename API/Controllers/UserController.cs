using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Configuration;
using System.Reflection;

namespace API.Controllers
{
    /// <summary>
    /// API for Location control
    /// </summary>
    public class UserController : ApiController
    {
        DeskShell db = new DeskShell();

        [HttpPost]
        [AllowAnonymous]
        [Route("api/register", Name = "Register")]
        [ResponseType(typeof(IHttpActionResult))]
        public IHttpActionResult Register(UserRegistration user)
        {
            try
            {
                if (user == null || !ValidateObjectProperties(user))
                    return BadRequest("Invalid User!");
                else if (db.Users.Where(x => x.Username.ToLower().Equals(user.Username)).FirstOrDefault() != null)
                    return BadRequest("Username already exists!");
                
                db.Users.Add(new User()
                {
                    Username = user.Username,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Password = Crypto.EncryptString(user.Password),
                    Created = DateTime.UtcNow,
                    LastLogin = null
                });
                db.SaveChanges();

                return Ok($"Succesfully Created New User {user.Username}.");
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to create new user account!");
            }
        }

        /// <summary>
        /// Validates all properites of object that they aren't null or whitespace
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool ValidateObjectProperties(object obj)
        {
            foreach (PropertyInfo property in obj.GetType().GetProperties())
            {
                if (property == null)
                {
                    return false;
                }

                if (property.PropertyType == typeof(string))
                {
                    string value = (string)property.GetValue(obj);
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        return false;
                    }
                }
            }
            return true;
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

                existingUser.LastLogin = DateTime.UtcNow;
                db.SaveChanges();

                return Ok("Success!");
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to Login");
            }
        }
    }
}