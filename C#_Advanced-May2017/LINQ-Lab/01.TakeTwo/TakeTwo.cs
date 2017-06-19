using System;
using System.Collections.Generic;
using System.Linq;

public class TakeTwo
{
    public static void Main()
    {
        Console.ReadLine()
           .Split()
           .Select(int.Parse)
           .Where(n => n >= 10 && n <= 20)
           .Distinct()
           .Take(2)
           .ToList()
           .ForEach(n => Console.Write(n + " "));

    }
}

