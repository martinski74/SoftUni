using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class ExtractIntegerNumbers
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Regex regex = new Regex("\\d+");
        var matches = regex.Matches(input);
        foreach (Match m in matches)
        {
            Console.WriteLine(m);
        }
    }
}

