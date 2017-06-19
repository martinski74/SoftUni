
namespace _08.WeakStudnts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WeakStudnts
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var studentsGroup = new List<string[]>();

            while (input != "END")
            {
                var studentName = input.Trim().Split();
                studentsGroup.Add(studentName);

                input = Console.ReadLine();
            }

            studentsGroup.Where(x => x.Where(g => g == "3").Count() + x.Where(g => g == "2").Count() >= 2)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x[0]} {x[1]}"));
        }
    }
}
