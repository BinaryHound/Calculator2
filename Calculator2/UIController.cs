using Common;
using Common.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskShell
{
    class UIController
    {
        public string Register(string username, string password, string firstName, string lastName)
        {
            var result = DeskShellAPI.Register(new UserRegistration
            {
                Username = StringMethods.Encode(username),
                Password = StringMethods.Encode(password),
                FirstName = StringMethods.Encode(firstName),
                LastName = StringMethods.Encode(lastName)
            });

            if (result.Success)
            {
                return string.Empty;
            }
            else
            {
                return result.Message;
            }
        }

        public string Login(string username, string password)
        {
            var result = DeskShellAPI.Login(new UserAuthentication
            {
                Username = StringMethods.Encode(username),
                Password = StringMethods.Encode(password)
            });

            if (result.Success)
            {
                // TODO: Set application settings with user info
                return string.Empty;
            }
            else
                return result.Message;
        }
    }
}
