using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        char[] separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
        string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        var lowerCase = new List<string>();
        var uperCase = new List<string>();
        var mixedCase = new List<string>();

        foreach (var w in words)
        {
            var type = GetWordType(w);
            if (type==WordType.UpperCase)
            {
                uperCase.Add(w);
            }
            else if (type==WordType.LowerCase)
            {
                lowerCase.Add(w);
            }
            else
            {
                mixedCase.Add(w);
            }
        }
        Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
        Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
        Console.WriteLine("Upper-case: {0}", string.Join(", ", uperCase));

    }
    enum WordType { UpperCase, MixedCase, LowerCase };
    static WordType GetWordType(string word)
    {
        var lowerLetters = 0;
        var upperLetters = 0;
        foreach (var l in word)
        {
            if (char.IsUpper(l))
            {
                upperLetters++;
            }
            else if (char.IsLower(l))
            {
                lowerLetters++;
            }
           
        }
        if (upperLetters == word.Length)
        {
            return WordType.UpperCase;
        }
        if (lowerLetters == word.Length)
        {
            return WordType.LowerCase;
        }
        return WordType.MixedCase;
    }
}

