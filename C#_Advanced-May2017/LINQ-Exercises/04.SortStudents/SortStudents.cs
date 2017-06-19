
namespace _04.SortStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortStudents
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
            studentsGroup.OrderBy(x => x[1])
                .ThenByDescending(x => x[0])
                .ToList()
                .ForEach(x => Console.WriteLine($"{x[0]} {x[1]}"));
        }
    }
}
