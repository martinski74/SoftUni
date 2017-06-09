using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class MatchCount
{
    public static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();

        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(text);
        Console.WriteLine(matches.Count);
    }
}

