using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int[] counts = new int[1001];
        foreach (var num in numbers)
        {
            counts[num]++;
        }
        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i] > 0)
            {
                Console.WriteLine("{0} -> {1}", i, counts[i]);
            }
            
        }
    }
}

