using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PeriodicTable
{
    class PeriodicTable
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sorted = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var token = Console.ReadLine().Split(' ');

                foreach (var item in token)
                {
                    sorted.Add(item);
                }
            }

            Console.WriteLine(String.Join(" ",sorted));
        }
    }
}
