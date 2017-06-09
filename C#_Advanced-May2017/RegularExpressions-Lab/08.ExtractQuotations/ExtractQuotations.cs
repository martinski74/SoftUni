using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class ExtractQuotations
{
    public static void Main()
    {
        string input = Console.ReadLine();

        Regex regex = new Regex("(\"|')(.*?)\\1");
        MatchCollection matches = regex.Matches(input);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups[2].Value);
        }
    }
}

