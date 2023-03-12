using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
    public class UserViewModel
    {
        private User _user;

        public UserViewModel(User user)
        {
            _user = user;
        }

        public string Name
        {
            get{ return _user.Name; }
            set{ _user.Name = value; }
        }

        public string Password
        {
            get
            {
                char[] chrArr = _user.Password.ToCharArray();

                for (int i = 0; i < _user.Password.Length; i++)
                {
                    chrArr[i] -= (Char)1;
                }

                return chrArr.ToString();
            }
            set
            {
                char[] chrArr = value.ToCharArray();

                for(int i = 0; i < value.Length; i++)
                {
                    chrArr[i] += (Char)1;
                }

                _user.Password = chrArr.ToString();
            }
        }

        public UserRolesEnum Role
        {
            get{ return _user.Role; }
            set{ _user.Role = value; }
        }

        public string email
        {
            get { return _user.email; }
            set { _user.email = value; }
        }

        public string facNum
        {
            get { return _user.facNum; }
            set { _user.facNum = value; }
        }

    }
}
