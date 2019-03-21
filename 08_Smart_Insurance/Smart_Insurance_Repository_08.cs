using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Smart_Insurance
{
    public class Smart_Insurance_Repository_08
    {
        private List<User_08> _userList;

        public Smart_Insurance_Repository_08()
        {
            _userList = new List<User_08>();

        }
        public void AddUserToList(User_08 newUser)
        {

            _userList.Add(newUser);

        }
        public List<User_08> GetUsersList()
        {
            return _userList;
        }
    }
}
