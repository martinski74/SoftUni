using System;
using System.Collections.Generic;
using System.Linq;

public class PredicateForNames
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var names = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        Predicate<string> filteredNames = name => name.Length <= n;

        foreach (var name in names)
        {
            if (filteredNames(name))
            {
                Console.WriteLine(name);
            }
        }
    }
}

