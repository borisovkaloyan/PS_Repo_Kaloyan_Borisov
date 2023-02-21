using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;
using Welcome.ViewModel;
using Welcome.View;

namespace Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            User usr = new User();
            usr.Name = "Pesho";
            usr.Password = "Y3DFqwdqD112";
            usr.Role = UserRolesEnum.STUDENT;
            usr.facNum = "12341234";
            usr.email = "asdffgsd@swefr.vdf";

            UserViewModel usrViewMdl = new UserViewModel(usr);

            UserView usrView = new UserView(usrViewMdl);

            usrView.Display_basic();
            usrView.Display_full();

            Console.ReadKey();
        }
    }
}
