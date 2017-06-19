
namespace _03.StudentsByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsByAge
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
            studentsGroup.Where(x => int.Parse(x[2]) >= 18 && int.Parse(x[2]) <= 24)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x[0]} {x[1]} {x[2]}"));

        }
    }
}
