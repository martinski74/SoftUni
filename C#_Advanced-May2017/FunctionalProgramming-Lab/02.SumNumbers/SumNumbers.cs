using System;
using System.Collections.Generic;
using System.Linq;

public class SumNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse);
        Console.WriteLine(numbers.Count());
        Console.WriteLine(numbers.Sum());


    }
}

