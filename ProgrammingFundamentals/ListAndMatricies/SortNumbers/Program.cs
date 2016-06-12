using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var number = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
        number.Sort();
        Console.WriteLine(string.Join(" <= ",number));
    }
}

