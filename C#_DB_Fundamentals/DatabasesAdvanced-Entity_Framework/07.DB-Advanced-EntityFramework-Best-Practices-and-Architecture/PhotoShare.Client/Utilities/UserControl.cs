using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using PhotoShare.Models;

namespace PhotoShare.Client
{
    public static class UserControl
    {
        private static User loggedUser;
        private static bool isLogged = false;

        static UserControl()
        {
            
        }

        public static User LoggedUser
        {
            get { return loggedUser; }
        }

        public static bool IsLogged
        {
            get { return isLogged; }
        }


        public static string Authenticate(string userName, string password)
        {
            string result;
            using (var context = new PhotoShareContext())
            {
                var user = context.Users.FirstOrDefault(n => n.Username == userName);
                if (user == null)
                {
                 throw new AuthenticationException("Invalid username or password!");
                }
                if (user.IsDeleted.Value)
                {
                    throw new AuthenticationException("Invalid username or password!");
                }
                if (user.Password != password)
                {
                    throw new AuthenticationException("Invalid username or password!");
                }
                loggedUser = user;
                isLogged = true;
                result = $"User {loggedUser.Username} successfully logged in!";
            }

            return result;
        }

        public static string LogOut()
        {
            string result ="";
            if (isLogged)
            {
                string loggedUserBuffer = loggedUser.Username;
                loggedUser = null;
                isLogged = false;
                result = $"User {loggedUserBuffer} successfully logged out!";
            }
            return result;
        }

    }
}
