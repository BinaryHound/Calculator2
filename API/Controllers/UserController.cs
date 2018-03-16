using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Configuration;
using System.Reflection;
using Common;
using Common.Data;

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
        [ResponseType(typeof(APIResult))]
        public IHttpActionResult Register(UserRegistration user)
        {
            try
            {
                if (!ValidateObject(user))
                {
                    return Ok(new APIResult
                    {
                        Success = false,
                        Message = "Invalid User",
                        Data = null
                    });
                }

                var decodedUserName = StringMethods.Decode(user.Username);
                if (db.Users.Where(x => x.Username.ToLower().Equals(decodedUserName)).FirstOrDefault() != null)
                {
                    return Ok(new APIResult
                    {
                        Success = false,
                        Message = "User Already Exists",
                        Data = null
                    });
                }

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

                return Ok(new APIResult
                {
                    Success = true,
                    Message = "Successfully created new user",
                    Data = new UserClient
                    {
                        FirstName = StringMethods.Decode(user.FirstName),
                        LastName = StringMethods.Decode(user.LastName)
                    }
                });
            }
            catch (Exception ex)
            {
                return Ok(new APIResult
                {
                    Success = false,
                    Message = "Failed to Create User Account",
                    Data = null
                });                
            }
        }        

        [HttpPost]
        [AllowAnonymous]
        [Route("api/login", Name = "Login")]
        [ResponseType(typeof(APIResult))]
        public IHttpActionResult Login(UserAuthentication user)
        {
            try
            {
                if (!ValidateObject(user))
                {
                    return Ok(new APIResult
                    {
                        Success = false,
                        Message = "Invalid Login",
                        Data = null
                    });
                }

                var decodedUserName = StringMethods.Decode(user.Username);
                var existingUser = db.Users.Where(x => x.Username.ToLower().Equals(decodedUserName.ToLower())).FirstOrDefault();

                if (existingUser == null || !Crypto.CompareString(StringMethods.Decode(user.Password), existingUser.Password))
                {
                    return Ok(new APIResult
                    {
                        Success = false,
                        Message = "Invalid Login",
                        Data = null
                    });
                }

                existingUser.LastLogin = DateTime.UtcNow;
                db.SaveChanges();

                return Ok(new APIResult
                {
                    Success = true,
                    Message = "Login Success",
                    Data = new UserClient
                    {
                        FirstName = existingUser.FirstName,
                        LastName = existingUser.LastName
                    }
                });
            }
            catch (Exception ex)
            {
                return Ok(new APIResult
                {
                    Success = false,
                    Message = "Failed to Login",
                    Data = null
                });
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
    }
}