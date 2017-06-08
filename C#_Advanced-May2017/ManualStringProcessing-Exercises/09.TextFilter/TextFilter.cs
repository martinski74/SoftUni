using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TextFilter
{
    public static void Main()
    {
        var bannedWords = Console.ReadLine()
            .Split(',')
            .Select(p => p.Trim())
            .ToArray();
        string text = Console.ReadLine();

        StringBuilder sb = new StringBuilder(text);

        foreach (var word in bannedWords)
        {
            string mask = new string('*', word.Length);
            sb.Replace(word, mask);
        }
        Console.WriteLine(sb.ToString());
    }
}

