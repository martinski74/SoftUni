using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse);
        var sorted = numbers.OrderByDescending(x => x).Take(3);
        Console.WriteLine(string.Join(" ",sorted));
    }
}

