using System.ComponentModel;
using System.Security.Principal;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using Welcome.Model;
using static WelcomeExtended.Others.Delegates;
using WelcomeExtended.Loggers;

namespace WelcomeExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var user = new User
                {
                    Name = "John Smith",
                    Password = "password123",
                    Role = UserRolesEnum.STUDENT
                };

                var viewModel = new UserViewModel(user);
                var view = new UserView(viewModel);

                view.DisplayBasic();

                view.DisplayError();
            }
            catch (Exception e)
            {
                var log = new ActionOnError(Log);
                log(e.Message);

                log = new ActionOnError(logFile);
                log(e.Message);
            }
            finally 
            {
                Console.WriteLine("Executed in any case!");
            }
        }
    }
}