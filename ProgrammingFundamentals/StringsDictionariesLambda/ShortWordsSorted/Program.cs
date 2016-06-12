using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine(string.Join(", ", Console.ReadLine().Split(new char[]
        { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, 
        StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).Where(x => x.Length < 5).OrderBy(x => x).Distinct()));
    }
}

