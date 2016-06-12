using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var squares = new List<int>();

        foreach (var num in numbers)
        {
            if (Math.Sqrt(num) == (int)Math.Sqrt(num))
            {
                squares.Add(num);
            }
        }
         squares.Sort();
         squares.Reverse();
        Console.WriteLine(string.Join(" ", squares));
    }
}

