using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();

        if (text.Length < 20)
        {
            Console.WriteLine(text.PadRight(20,'*'));
        }
        else
        {
            Console.WriteLine(text.Substring(0,20));
        }
    }
}

