using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int k = numbers.Count / 4;

        List<int> leftUp = numbers.Take(k).Reverse().ToList();
        List<int> rightUp = numbers.Skip(3 * k).Take(k).Reverse().ToList();
        List<int> leftRight = leftUp.Concat(rightUp).ToList();
        List<int> midlPart = numbers.Skip(k).Take(2 * k).ToList();

        List<int> result = leftRight.Select((x, index) => x + midlPart[index]).ToList();
        Console.WriteLine(string.Join(" ",result));
    }
}

