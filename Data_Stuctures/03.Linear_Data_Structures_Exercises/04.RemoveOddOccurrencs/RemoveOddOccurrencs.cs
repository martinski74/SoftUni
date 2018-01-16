using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RemoveOddOccurrencs
{
    public class RemoveOddOccurrencs
    {
        public static void Main()
        {
            var resultList = new List<int>();

            var numbers = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int i1 = numbers[i];
                if (numbers
                    .Where(x => x == i1)
                    .ToList()
                    .Count() % 2 == 0)
                {
                    resultList.Add(i1);
                }
            }
            Console.WriteLine(string.Join(" ",resultList));
        }
    }
}
