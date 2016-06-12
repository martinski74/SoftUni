using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var list = new List<int>();

        foreach (var num in nums)
        {
            if (num >= 0)
            {
                list.Add(num);
            }
        }
        list.Reverse();
        if (list.Count == 0)
        {
            Console.WriteLine("empty");
        }
        Console.WriteLine(string.Join(" ",list));
    }
}

