using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        for (int i = text.Length -1; i >= 0; i--)
        {
            Console.Write(text[i]);
        }
        Console.WriteLine();
    }
}

