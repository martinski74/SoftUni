using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class ReplaceTags
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"<a.*?href.*?=(.*?)>(.*?)<\/a>";
        string resultPattern = @"[URL href=$1]$2[/URL]";

        while (input!="end")
        {
            string replaced = Regex.Replace(input,pattern, resultPattern);
            Console.WriteLine(replaced);
            input = Console.ReadLine();
        }
    }
}

