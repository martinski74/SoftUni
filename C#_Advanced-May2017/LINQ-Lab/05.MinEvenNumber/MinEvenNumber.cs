using System;
using System.Collections.Generic;
using System.Linq;

public class MinEvenNumber
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ').Select(double.Parse)
            .ToList();
        double result = numbers.Where(n => n % 2 == 0)
            .OrderBy(n => n)
            .FirstOrDefault();

        if (result != 0)
        {
            Console.WriteLine($"{result:F2}");
        }
        else
        {
            Console.WriteLine("No match");
        }
    }
}

