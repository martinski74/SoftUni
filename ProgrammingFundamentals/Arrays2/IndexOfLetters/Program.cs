using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        foreach (var ch in input)
        {
            Console.WriteLine("{0} -> {1}", ch, ch - 'a');
        }
    }
}

