using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

public class SemanticHTML
{
    public static void Main()
    {
        List<string> semantic = new List<string>();

        string[] acceptables = new string[] { "main", "header", "nav", "article", "section", "aside", "footer" };

        string patternOpenTag = @"<div.*?\b((id|class)\s*=\s*""(.*?)"").*?>";
        string patternCloseTag = @"<\/div>.*?<!--\s*(\w+)\s*-->";

        string inputLine = Console.ReadLine();

        while (inputLine != "END")
        {
            Match matchOpen = Regex.Match(inputLine, patternOpenTag);
            Match matchClose = Regex.Match(inputLine, patternCloseTag);

            if (matchOpen.Success && acceptables.Contains(matchOpen.Groups[3].Value))
            {
                string processing = Regex.Replace(matchOpen.ToString(), "div", tag => matchOpen.Groups[3].Value);
                processing = Regex.Replace(processing, matchOpen.Groups[1].Value, "");
                processing = Regex.Replace(processing, "\\s*>", ">");
                processing = Regex.Replace(processing, "\\s{2,}", " ");
                inputLine = Regex.Replace(inputLine, matchOpen.ToString(), processing);
            }
            else if (matchClose.Success && acceptables.Contains(matchClose.Groups[1].Value))
            {
                string replace = String.Format("</" + matchClose.Groups[1].Value + ">");
                inputLine = Regex.Replace(inputLine, matchClose.ToString(), replace);
            }

            semantic.Add(inputLine);

            inputLine = Console.ReadLine();
        }

        foreach (string row in semantic)
        {
            Console.WriteLine(row);
        }
    }
}

