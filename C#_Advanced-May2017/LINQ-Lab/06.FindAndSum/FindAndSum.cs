using System;
using System.Collections.Generic;
using System.Linq;

public class FindAndSum
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Where(x => !x.Any(y => char.IsLetter(y)))
            .Select(long.Parse);

        Console.WriteLine(input.Count().Equals(0)?"No match": input.Sum().ToString());


    }
}

