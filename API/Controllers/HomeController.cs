using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace API.Controllers
{
    /// <summary>
    /// API for Location control
    /// </summary>
    public class HomeController : ApiController
    {
        [HttpGet]
        [AllowAnonymous]
        [Route("api/test", Name = "Test")]
        [ResponseType(typeof(string))]
        public IHttpActionResult Test(string message)
        {
            return Ok(message);
        }
    }
}