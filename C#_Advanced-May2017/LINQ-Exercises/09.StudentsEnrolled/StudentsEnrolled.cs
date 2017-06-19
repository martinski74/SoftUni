
namespace _09.StudentsEnrolled
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsEnrolled
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

            studentsGroup.Where(x => x[0].Substring(x[0].Length - 2) == "14" ||
                x[0].Substring(x[0].Length - 2) == "15");

            foreach (var student in studentsGroup)
            {
                Console.WriteLine($"{string.Join(" ", student.Where((x, i) => i > 0))}");
            }


        }
    }
}
