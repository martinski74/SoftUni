using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        string[] sentences = text.Split('.','!','?');

        foreach (var sentence in sentences)
        {
            string[] words = Regex.Split(sentence,"[^A-Za-z]");

            if (words.Contains(word))
            {
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}

