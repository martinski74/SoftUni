using System;
using System.Linq;
class Program
{
    static void Main()
    {
        decimal[] numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
       
        Console.WriteLine(@"/----------------------\");
        foreach (var num in numbers)
        {
            Console.WriteLine(@"| {0,20:f2} |",num);
        }
        Console.WriteLine("|----------------------|");
        Console.WriteLine(@"| Total: {0,13:f2} |",numbers.Sum());
        Console.WriteLine(@"\----------------------/");

    }
}

