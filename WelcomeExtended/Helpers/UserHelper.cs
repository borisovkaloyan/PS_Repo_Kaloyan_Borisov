using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {
        public static void ToString(this User user)
        {
            Console.WriteLine("Found User with username: " + user.Name);
            Console.WriteLine("Identifer: " + user.Id);
            Console.WriteLine("Role: " + user.Role);
        }

        public static bool ValidateCredentials(UserData userData, string name, string password)
        {
            if (name == "")
            {
                throw new Exception("Name cannot be empty");
            }

            if (password == "")
            {
                throw new Exception("Password cannot be empty");
            }

            return userData.ValidateUser(name, password);
        }

        public static User GetUser(UserData userData, string name, string password)
        {
            if (name == "")
            {
                throw new Exception("Name cannot be empty");
            }

            if (password == "")
            {
                throw new Exception("Password cannot be empty");
            }

            return userData.GetUser(name, password);
        }
    }
}
