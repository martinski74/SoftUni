namespace _03.Linear_Data_Structures_Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAndAverage
    {
        public static void Main()
        {
            var resultList = new List<int>();
           

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (var item in input)
            {
                resultList.Add(item);
            }
            var sum = resultList.Sum();
            var avg = resultList.Average();
            Console.WriteLine($"Sum={sum}; Average={avg:f2}");
        }
    }
}
