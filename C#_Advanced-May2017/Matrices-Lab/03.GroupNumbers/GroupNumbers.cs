using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GroupNumbers
{
    class GroupNumbers
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var zero = input.Where(n => Math.Abs(n) % 3 == 0).ToArray();
            var one = input.Where(n => Math.Abs(n) % 3 == 1).ToArray();
            var two = input.Where(n => Math.Abs(n) % 3 == 2).ToArray();

            Console.WriteLine(string.Join(" ",zero));
            Console.WriteLine(string.Join(" ",one));
            Console.WriteLine(string.Join(" ",two));
        }
    }
}
