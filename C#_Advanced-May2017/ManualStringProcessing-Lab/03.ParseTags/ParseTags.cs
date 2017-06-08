using System;
using System.Collections.Generic;

public class ParseTags
{
    public static void Main()
    {
        var input = Console.ReadLine();
        string openTag = "<upcase>";
        string closeTag = "</upcase>";

        int startIndex = input.IndexOf(openTag);
        while (startIndex != -1)
        {
            int endIndex = input.IndexOf(closeTag);
            if (endIndex == -1)
            {
                break;
            }

            string upcase = input.Substring(startIndex, endIndex - startIndex + closeTag.Length);
            string replaceUpcase = upcase
                .Replace(openTag, "")
                .Replace(closeTag, "")
                .ToUpper();
            input = input.Replace(upcase, replaceUpcase);
            startIndex = input.IndexOf(openTag);
        }
        Console.WriteLine(input);

    }
}

