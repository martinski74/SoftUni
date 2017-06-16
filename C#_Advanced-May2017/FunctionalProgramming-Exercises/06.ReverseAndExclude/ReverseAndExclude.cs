using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReverseAndExclude
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray().Reverse();
        int n = int.Parse(Console.ReadLine());

        var result = numbers.Where(num => num % n != 0);
        Console.WriteLine(string.Join(" ",result));
       
    }
}

