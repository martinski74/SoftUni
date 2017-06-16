using System;
using System.Collections.Generic;
using System.Linq;

public class CustomMinFunction
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Func<int[], int> minNumber = num => num.Min();

        Console.WriteLine(minNumber(numbers));
    }
}

