using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoShare.Client.Core.Commands
{
    class LoginCommand
    {
        // Login <username> <password>

        public string Execute(string[] data)
        {
            string user = data[0];
            string password = data[1];
            string result;

            if (UserControl.IsLogged)
            {
                throw new ArgumentException("You should logout first!");
            }
            result = UserControl.Authenticate(user, password);

            return result;
        }


    }
}
