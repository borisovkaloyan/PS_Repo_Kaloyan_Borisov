using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;

namespace Welcome.View
{
    class UserView
    {
        private UserViewModel _viewModel;

        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel; 
        }

        public void Display_basic()
        {
            Console.WriteLine("Welcome (basic)" + "\nUser: " + _viewModel.Name + "\nRole: " + _viewModel.Role);
        }
        public void Display_full()
        {
            Console.WriteLine("\nWelcome (full)" + "\nUser: " + _viewModel.Name + "\nRole: " +
                              _viewModel.Role + "\nemail: " + _viewModel.email + "\nFaculty number: " + _viewModel.facNum);
        }
    }
}
