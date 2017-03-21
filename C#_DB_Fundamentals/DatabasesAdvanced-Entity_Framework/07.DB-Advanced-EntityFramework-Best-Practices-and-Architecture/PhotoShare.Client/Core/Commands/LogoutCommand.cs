using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoShare.Client.Core.Commands
{
    class LogoutCommand
    {
        public string Execute()
        {
            string result;

            if (!UserControl.IsLogged)
            {
                throw new InvalidOperationException($"You should log in first in order to logout.");
            }
            result = UserControl.LogOut();
            return result;
        }
    }
}
