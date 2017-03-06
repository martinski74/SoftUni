using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveInactiveUsers
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "dd MMM yyyy", CultureInfo.InvariantCulture);
           

            var context = new RemoveEntities();
            using (context)
            {
                var users = context.Users
                    .Where(x => x.LastTimeLoggedIn < date); //Geting users

                int affected = context.Users.Count(x => x.LastTimeLoggedIn < date); //Geting users count

                foreach (var user in users)
                {
                    user.IsDeleted = true;
                }
                context.SaveChanges();
                Console.WriteLine(affected > 0 ? $"{affected} users have been deleted" : "No users have been deleted");
            }
        }
    }
}
