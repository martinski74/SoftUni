
namespace _01.StudentsByGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsByGroup
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
            var result = studentsGroup.Where(x =>x[x.Length - 1] == "2")
                .OrderBy(x => x[0]);
            foreach (var item in result)
            {
                Console.WriteLine($"{item[0]} {item[1]}");
            }
        }
    }
}
