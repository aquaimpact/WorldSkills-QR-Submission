using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    class SharedPrefs
    {
        User user;
        public User GetUser()
        {
            return user;
        }

        public void SetUser(User users)
        {
            user = users;
        }
    }
}
