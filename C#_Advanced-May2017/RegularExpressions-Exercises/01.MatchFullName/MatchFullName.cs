using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class MatchFullName
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var regexString = "^\\b[A-Z][a-z]+\\b \\b[A-Z][a-z]+\\b$";
        var regex = new Regex(regexString);
        while (input != "end")
        {
            if (regex.IsMatch(input))
            {
                Console.WriteLine(input);
            }
            input = Console.ReadLine();
        }
    }
}


