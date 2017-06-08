using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UnicodeCharacters
{
    public static void Main()
    {
        var input = Console.ReadLine();
        foreach (var chr in input)
        {
            Console.Write("\\u{0:x4}", (int)chr);
        }
        Console.WriteLine();
    }
}

