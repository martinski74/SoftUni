using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        char[] first = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        char[] second = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

        string[] arrays = { new string(first), new string(second) };
        Array.Sort(arrays);

        Console.WriteLine(string.Join("\n",arrays));
    }
}

