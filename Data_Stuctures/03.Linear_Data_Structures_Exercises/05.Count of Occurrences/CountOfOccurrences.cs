using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Count_of_Occurrences
{
    public class CountOfOccurrences
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                               .Split(' ')
                               .Select(int.Parse).ToArray();

            var resultDict = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!resultDict.ContainsKey(number))
                {
                    resultDict[number] = 0;
                }
                resultDict[number]++;
            }
            foreach (var item in resultDict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value} times");
            }

        }
    }
}
