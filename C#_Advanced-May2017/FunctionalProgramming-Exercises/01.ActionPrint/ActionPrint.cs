using System;
using System.Collections.Generic;
using System.Linq;

public class ActionPrint
{
    public static void Main()
    {
        var input = Console.ReadLine().Split().ToArray();
        Action<string> print = n => Console.WriteLine(n);

        foreach (var name in input)
        {
            print(name);
        }

    }
}

