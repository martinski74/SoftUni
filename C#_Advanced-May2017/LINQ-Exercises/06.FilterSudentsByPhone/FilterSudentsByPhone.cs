
namespace _06.FilterSudentsByPhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterSudentsByPhone
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

            studentsGroup.Where(x => x[2].Substring(0, 2) == "02" ||
            x[2].Substring(0, 5) == "+3592")
            .ToList()
            .ForEach(x => Console.WriteLine($"{x[0]} {x[1]}"));
        }
    }
}
