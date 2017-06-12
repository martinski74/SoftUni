using System;
using System.Text.RegularExpressions;

public class SentenceExtractor
{
    public static void Main()
    {
        string keyword = Console.ReadLine();
        string text = Console.ReadLine();

        Regex regex = new Regex(@".+?[!\./?]");
        MatchCollection matches = regex.Matches(text);
        foreach (Match match in matches)
        {
            if (match.Value.Contains(" "+keyword+" "))
            {
                Console.WriteLine(match.Value.Trim());
            }
        }

    }
}

