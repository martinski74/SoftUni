using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.LogsAggregator
{
    class LogsAggregator
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var users = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var ip = tokens[0];
                var user = tokens[1];
                var duration = int.Parse(tokens[2]);

                if (!users.ContainsKey(user))
                {
                    users[user] = new SortedDictionary<string, int>();
                }
                if (!users[user].ContainsKey(ip))
                {
                    users[user][ip] = 0;
                }
                users[user][ip] += duration;

            }

            foreach (var user in users.Keys)
            {
                Console.WriteLine($"{user}: {users[user].Values.Sum()} [{string.Join(", ",users[user].Keys)}]");
            }
        }
    }
}
