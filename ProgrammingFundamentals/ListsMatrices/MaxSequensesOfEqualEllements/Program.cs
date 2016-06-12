using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int start = 0;
        int len = 0;
        int bestLen = 0;

        for (int i = 0; i < numbers.Count-1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                len++;
                if (len > bestLen)
                {
                    bestLen = len;
                    start = i - len;
                }
            }
            else
            {
                len = 0;
            }
        }
        if (numbers.Count == 1)
        {
            Console.WriteLine(numbers[0]);
            return;
        }
        for (int i = start+1; i <= start+bestLen+1; i++)
        {
            Console.Write(numbers[i]+" ");
        }
        Console.WriteLine();
    }
}

