using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SetsOfElements
{
    class SetsOfElements
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var firstSet = new HashSet<int>();
            var secondtSet = new HashSet<int>();

            for (int i = 0; i < input[0]; i++)
            {
                var number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }
            for (int i = 0; i < input[1]; i++)
            {
                var number = int.Parse(Console.ReadLine());
                secondtSet.Add(number);
            }
            Console.WriteLine();
            foreach (var item in firstSet)
            {
                if (secondtSet.Contains(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
