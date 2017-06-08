using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Palindromes
{
    public static void Main()
    {
        var palindromes = new SortedSet<string>();
        char[] delimiters = new []{ ' ', ',', '.', '?', '!' };
        var words = Console.ReadLine()
            .Split(delimiters,StringSplitOptions.RemoveEmptyEntries)
            .Select(p => p.Trim())
            .ToList();

        foreach (var word in words)
        {
            if (IsPalindromes(word))
            {
                palindromes.Add(word);
            }
        }
        Console.Write("[");
        Console.Write(string.Join(", ",palindromes));
        Console.WriteLine("]");
    }

    private static bool IsPalindromes(string word)
    {
        if (word.Length == 1)
        {
            return true;
        }
        int len = word.Length;
        for (int i = 0; i < len/2; i++)
        {
            if (word[i] != word[len - i -1])
            {
                return false;
            }
        }
        return true;
    }
}

