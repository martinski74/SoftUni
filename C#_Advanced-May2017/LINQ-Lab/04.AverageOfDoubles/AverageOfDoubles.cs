using System;
using System.Linq;

public class AverageOfDoubles
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        Console.WriteLine($"{numbers.Average():F2}");
    }
}

