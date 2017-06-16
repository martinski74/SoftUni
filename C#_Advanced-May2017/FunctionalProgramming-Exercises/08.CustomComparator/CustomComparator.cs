using System;
using System.Collections.Generic;
using System.Linq;

class CustomComparator
{
    static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();

        var evenNums = nums.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
        var oddNums = nums.Where(x => x % 2 != 0).OrderBy(x => x).ToList();

        Console.WriteLine(string.Join(" ", evenNums) + " " + string.Join(" ", oddNums));
    }
}

