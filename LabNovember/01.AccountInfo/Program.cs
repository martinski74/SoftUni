using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AccountInfo
{
    class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int clientId = int.Parse(Console.ReadLine());
            decimal accountBalance = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Hello, {0} {1}", firstName, lastName);
            Console.WriteLine("Client id: {0}", clientId);
            Console.WriteLine("Total balance: {0:F2}", accountBalance);
            Console.WriteLine(accountBalance >= 0 ? "Active: yes" : "Active: no");
        }
    }
}
