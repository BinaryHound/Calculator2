using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskShell
{
    class UserGreeting
    {
        public static string FirstName { get; set; }
        public static string LastName { get; set; }

        public UserGreeting(object obj)
        {
            // TODO: set first name, and last name here for main application();
            Console.WriteLine(obj);
            //no idea how to decouple a javascript object in c#

        }
    }
}
