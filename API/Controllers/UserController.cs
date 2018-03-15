using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Configuration;
using System.Reflection;
using Common;

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
                if (!ValidateObject(user))
                    return BadRequest("Invalid User!");
                else if (db.Users.Where(x => x.Username.ToLower().Equals(StringMethods.Decode(user.Username))).FirstOrDefault() != null)
                    return BadRequest("Username already exists!");
                
                db.Users.Add(new User()
                {
                    Username = StringMethods.Decode(user.Username),
                    FirstName = StringMethods.Decode(user.FirstName),
                    LastName = StringMethods.Decode(user.LastName),
                    Password = Crypto.EncryptString(StringMethods.Decode(user.Password)),
                    Created = DateTime.UtcNow,
                    LastLogin = null
                });
                db.SaveChanges();

                return Ok($"Succesfully Created New User.");
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to create new user account!");
            }
        }

        /// <summary>
        /// Validates all properites of object that they aren't null, or whitespace if a string
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool ValidateObject(object obj)
        {
            if (obj == null)
                return false;

            foreach (PropertyInfo property in obj.GetType().GetProperties())
            {
                if (property == null)
                    return false;

                if (property.PropertyType == typeof(string))
                {
                    string value = (string)property.GetValue(obj);
                    if (string.IsNullOrWhiteSpace(value))
                        return false;
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
            if (!ValidateObject(user))
                return BadRequest("Invalid Login");

            try
            {                               
                var existingUser = db.Users.Where(x => x.Username.ToLower().Equals(StringMethods.Decode(user.Username.ToLower()))).FirstOrDefault();

                if (existingUser == null || !Crypto.CompareString(StringMethods.Decode(user.Password), existingUser.Password))
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