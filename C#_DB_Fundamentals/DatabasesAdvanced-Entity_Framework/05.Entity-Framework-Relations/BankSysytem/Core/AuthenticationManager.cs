using BankSysytem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSysytem.Core
{
    public static class AuthenticationManager
    {
        private static User currentUser;

        /// <summary>
        /// Checks if there is current logged in user.
        /// </summary>
        /// <returns></returns>
        public static bool IsAuthenticated()
        {
            return currentUser != null;
        }

        /// <summary>
        /// Logout current user.
        /// </summary>
        public static void Logout()
        {
            if (!IsAuthenticated())
            {
                throw new InvalidOperationException("You should login first!");
            }

            currentUser = null;
        }

        /// <summary>
        /// Logs in the user specified.
        /// </summary>
        /// <param name="user"></param>
        public static void Login(User user)
        {
            if (IsAuthenticated())
            {
                throw new InvalidOperationException("You should logout first!");
            }

            if (user == null)
            {
                throw new InvalidOperationException("User to log in is invalid!");
            }

            currentUser = user;
        }

        /// <summary>
        /// Gets currently logged in user.
        /// </summary>
        /// <returns></returns>
        public static User GetCurrentUser()
        {
            return currentUser;
        }
    }
}
