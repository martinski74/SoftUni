
namespace _07.ExellentStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExellentStudents
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

            studentsGroup.Where(x => x.Contains("6"))
                .ToList()
                .ForEach(x => Console.WriteLine($"{x[0]} {x[1]}"));
        }
    }
}
