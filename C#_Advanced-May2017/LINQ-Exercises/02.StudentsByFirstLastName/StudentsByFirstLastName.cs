namespace _02.StudentsByFirstLastName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsByFirstLastName
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
            studentsGroup.Where(x => x[1].CompareTo(x[0]) == 1)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s[0]} {s[1]}"));
        }
    }
}
