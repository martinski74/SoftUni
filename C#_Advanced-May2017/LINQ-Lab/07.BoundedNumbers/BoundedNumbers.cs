using System;
using System.Collections.Generic;
using System.Linq;

public class BoundedNumbers
{
    public static void Main()
    {
        var boundNums = Console.ReadLine().Split().Select(int.Parse);
        Console.WriteLine(string.Join(" ", Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Where(x => x >= boundNums.Min() && x <= boundNums.Max())));
    }

}


