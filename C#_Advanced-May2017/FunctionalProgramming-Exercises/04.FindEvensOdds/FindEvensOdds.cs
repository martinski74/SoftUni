using System;
using System.Collections.Generic;
using System.Linq;

public class FindEvensOdds
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var numType = Console.ReadLine().ToLower();

        var evenNums = new List<int>();
        var oddNums = new List<int>();

        Predicate<int> pre =  a => a % 2 == 0;

        for (int i = numbers[0]; i <= numbers[1]; i++)
        {
            if (pre(i))
            {
                evenNums.Add(i);
            }
            else
            {
                oddNums.Add(i);
            }
        }
        var result = numType == "even" ? string.Join(" ", evenNums) :
            string.Join(" ", oddNums);

        Console.WriteLine(result);

    }
}

