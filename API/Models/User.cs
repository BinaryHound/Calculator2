using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;

namespace API.Models
{
    public class User
    {
        public string Username { get; set; }
        public string AuthKey { get; set; }
        public DateTime LastLogin { get; set; }
    }
}