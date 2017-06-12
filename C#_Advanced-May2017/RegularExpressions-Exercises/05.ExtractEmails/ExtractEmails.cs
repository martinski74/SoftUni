using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class ExtractEmails
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string patern = @"\b(?<!\S)[a-z][a-z0-9\.\-_]+[a-z0-9]*@[a-z][a-z\-]+\.[a-z][a-z\.]+[a-z]?\b";

        Regex regex = new Regex(patern);
        MatchCollection matches = regex.Matches(input);
        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

