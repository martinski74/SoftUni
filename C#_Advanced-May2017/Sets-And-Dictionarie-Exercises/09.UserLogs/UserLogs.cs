using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.UserLogs
{
    class UserLogs
    {
        static void Main()
        {
            var users = new SortedDictionary<string, Dictionary<string, int>>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var tokens = line.Split(' ');

                var ip = tokens[0].Replace("IP=","");
                var username = tokens[2].Replace("user=","");

                if (users.ContainsKey(username))
                {
                    if (users[username].ContainsKey(ip))
                    {
                        users[username][ip] += 1;
                    }
                    else
                    {
                        users[username][ip] = 1;
                    }
                }
                else
                {
                    users[username] = new Dictionary<string, int>() { { ip,1} };
                }

                line = Console.ReadLine();
            }

            PrintUsersAndIp(users);
        }

        private static void PrintUsersAndIp(SortedDictionary<string, Dictionary<string, int>> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}:");
                Console.WriteLine("{0}."
                    ,string.Join(", ",user.Value.Select(a => $"{a.Key} => {a.Value}")));
            }
        }
    }
}
