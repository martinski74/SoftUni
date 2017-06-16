using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class KnightsOfHonor
{
    static void Main()
    {
        var names = Console.ReadLine()
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        Action<string> print = name => Console.WriteLine("Sir " + name);

        foreach (var name in names)
        {
            print(name);
        }
    }
}

