using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FixEmails
{
    class FixEmails
    {
        static void Main()
        {
            string name = Console.ReadLine();

            Dictionary<string, string> emails = new Dictionary<string, string>();

            while (name != "stop")
            {
                string email = Console.ReadLine();

                string checkEnd = email.Substring(email.Length - 2, 2).ToLower();

                if (checkEnd != "uk" && checkEnd != "us")
                {
                    emails.Add(name, email);
                }

                name = Console.ReadLine();
            }

            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
