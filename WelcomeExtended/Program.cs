using System.ComponentModel;
using System.Security.Principal;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using Welcome.Model;
using static WelcomeExtended.Others.Delegates;
using WelcomeExtended.Loggers;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;
using System.Xml.Linq;

namespace WelcomeExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UserData userData = new UserData();

                User studentUser = new User()
                {
                    Name = "Student",
                    Password = "123",
                    Role = UserRolesEnum.STUDENT
                };

                userData.AddUser(studentUser);

                User studentUser2 = new User()
                {
                    Name = "Student2",
                    Password = "123",
                    Role = UserRolesEnum.STUDENT
                };

                userData.AddUser(studentUser2);

                User teacherUser = new User()
                {
                    Name = "Teacher",
                    Password = "1234",
                    Role = UserRolesEnum.PROFESSOR
                };

                userData.AddUser(teacherUser);

                User adminUser = new User()
                {
                    Name = "Admin",
                    Password = "12345",
                    Role = UserRolesEnum.ADMIN
                };

                userData.AddUser(adminUser);

                string username;
                Console.WriteLine("Input username: ");
                username = Console.ReadLine();

                string password;
                Console.WriteLine("Input password: ");
                password = Console.ReadLine();

                UserHelper.ValidateCredentials(userData, username, password);

                User gotUser = new User();
                gotUser = UserHelper.GetUser(userData, username, password);

                UserHelper.ToString(gotUser);
            }
            catch (Exception ex)
            {
                var log = new ActionOnError(Log);
                log(ex.Message);
            }
        }
    }
}