using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] words = Console.ReadLine().Split(' ');

        foreach (var w in words)
        {
            var stars = new string('*',w.Length);
            text = text.Replace(w,stars);
        }
        Console.WriteLine(text);
    }
}

