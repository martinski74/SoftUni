using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.UniqueUsernames
{
    class UniqueUsernames
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var users = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var userName = Console.ReadLine();
                users.Add(userName);
            }
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
}
