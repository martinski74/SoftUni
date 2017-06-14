using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SortEvenNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n))
            .Where(n => n % 2 == 0)
            .OrderBy(n => n)
            .ToList();
        Console.WriteLine(String.Join(", ",numbers));
        
    }
}

