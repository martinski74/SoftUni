using System;
using System.Collections.Generic;
using System.Linq;

public class AppliedAritmetics
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();


        var command = Console.ReadLine();
        while (command != "end")
        {
            switch (command)
            {
                case "add": numbers = numbers.Select(n => n + 1).ToArray(); break;
                case "multiply": numbers = numbers.Select(n => n * 2).ToArray(); break;
                case "subtract": numbers = numbers.Select(n => n - 1).ToArray(); break;
                case "print": Console.WriteLine(string.Join(" ", numbers)); ; break;

            }

            command = Console.ReadLine();
        }
    }
}

