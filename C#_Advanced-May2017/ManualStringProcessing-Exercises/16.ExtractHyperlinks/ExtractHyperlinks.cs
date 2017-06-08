using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class ExtractHyperlinks
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"<a.*?(?<!"">)href\s*?=\s*?([""'])?(\S.*?)(?:>|class|\1)";
        while (input.Substring(input.Length - 3) != "END")
        {
            input += Console.ReadLine();
        }
        input = input.Remove(input.Length - 3);
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        string fix;
        foreach (Match item in matches)
        {
            fix = item.Groups[2].ToString();
            fix = Regex.Replace(fix, @"\s{2,}", " ");
            Console.WriteLine(fix);
        }
    }
}

