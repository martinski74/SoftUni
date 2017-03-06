using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetUserByEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter occurrence pattern [like \"d.edu\"]: ");
            string pattern = Console.ReadLine();

            var context = new UserEntities();
            using (context)
            {
                var users = context.Users.Select(x => new
                {
                    x.Username,
                    x.Email,
                })
                .Where(x => x.Email.Contains(pattern)).ToList();

                foreach (var user in users)
                {
                    Console.WriteLine($"{user.Username} {user.Email}");
                }
            }
        }
    }
}
