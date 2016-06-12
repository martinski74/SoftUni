using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        char[] separators = new char[] 
        { '.', ',', ';', ':', '=', ')', '(', '&', '[', ']', '\'', '"', '\\', '/', '?', '!', ' ' };
        string text = Console.ReadLine();
        string[] words = text.Split(separators,StringSplitOptions.RemoveEmptyEntries);
        char[] nonSeparators = string.Join("",words).ToCharArray();
        string[] punctuation = text.Split(nonSeparators,StringSplitOptions.RemoveEmptyEntries);
        words = words.Reverse().ToArray();
        for (int i = 0; i < words.Length; i++)
        {
            Console.Write(words[i] + punctuation[i]); 
        }
        Console.WriteLine();
    }
}

