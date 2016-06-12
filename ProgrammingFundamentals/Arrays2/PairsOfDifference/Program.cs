using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int diff = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                int a = numbers[i];
                int b = numbers[j];
                if (Math.Abs(a - b)== diff)
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
       
    }
}

