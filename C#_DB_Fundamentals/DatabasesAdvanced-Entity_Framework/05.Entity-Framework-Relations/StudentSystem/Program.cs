using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentSystemContext context = new StudentSystemContext();
            //context.Database.Initialize(true);

            //03.Working with the Database 
            Exercise3_1(context);

            Exercise3_2(context);

            Exercise3_3(context);

            Exercise3_4(context);

            Exercise3_5(context);


        }

        private static void Exercise3_5(StudentSystemContext context)
        {
            var students = context.Students
                .OrderByDescending(x => x.Courses.Sum(z => z.Price))
                .ThenByDescending(x => x.Courses.Count)
                .ThenBy(x => x.Name).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"Student: {student.Name}");
                Console.WriteLine($"Number of courses: {student.Courses.Count}");
                Console.WriteLine($"Total price: {student.Courses.Sum(x => x.Price)}");
                Console.WriteLine($"Average price: {student.Courses.Average(x => x.Price)}");
                Console.WriteLine(new string('-', 50));
            }
            Console.WriteLine(new string('\n', 2));
        }

        private static void Exercise3_4(StudentSystemContext context)
        {
            //Course c1 = new Course("CS 101", new DateTime(1999, 08, 15), new DateTime(1999, 11, 15));
            //Course c2 = new Course("CS 301", new DateTime(2001, 08, 15), new DateTime(2001, 11, 15));
            //Course c3 = new Course("CS 666", new DateTime(2002, 08, 15), new DateTime(2003, 11, 15));
            //Course c4 = new Course("CS Test", new DateTime(2002, 08, 15), new DateTime(2003, 07, 12));
            DateTime checkAgainsDate = new DateTime(2002, 10, 10);
            foreach (var course in context.Courses.Where(
                    x => x.StartDate <= checkAgainsDate && x.EndDate >= checkAgainsDate).OrderByDescending(x => x.Students.Count).ThenBy(x => SqlFunctions.DateDiff("day", x.EndDate, x.StartDate)))
            {
                //
                Console.WriteLine($"Name: {course.Name}");
                Console.WriteLine($"StartDate: {course.StartDate}");
                Console.WriteLine($"EndDate: {course.EndDate}");
                Console.WriteLine($"Duration: {TimeDiff(course.StartDate, course.EndDate).Days} days");
                Console.WriteLine($"Students: {course.Students.Count}");
                Console.WriteLine(new string('-', 50));

            }
            Console.WriteLine(new string('\n', 2));
        }
        private static TimeSpan TimeDiff(DateTime start, DateTime end)
        {
            TimeSpan ts = end - start;
            return ts;
        }

        private static void Exercise3_3(StudentSystemContext context)
        {
            Console.WriteLine("3.List all courses with more than 5 resources");

            var cources = context.Courses
                .Where(x => x.Resources.Count > 1) // Must be 5 but there is not more than 5 in Database :)
                .OrderByDescending(x => x.Resources.Count)
                .ThenByDescending(x => x.StartDate).ToList();

            foreach (var cource in cources)
            {
                Console.WriteLine($"{cource.Name} {cource.Resources.Count} resources");
            }
        }

        private static void Exercise3_2(StudentSystemContext context)
        {
            Console.WriteLine("2.List all courses with their corresponding resources");

            var courses = context.Courses.OrderBy(c => c.StartDate).ThenByDescending(c => c.EndDate);

            foreach (var cource in courses)
            {
                Console.WriteLine($"Name: {cource.Name}");
                Console.WriteLine($"Description: {cource.Description}");
                foreach (var r in cource.Resources)
                {
                    Console.WriteLine($"Id: {r.Id}\n Name: {r.Name}\n Type: {r.Type}\n URL: {r.Url}");
                }
                Console.WriteLine();


            }
        }

        private static void Exercise3_1(StudentSystemContext context)
        {
            Console.WriteLine("List all students and their homework submissions");

            foreach (var student in context.Students)
            {
                Console.WriteLine($"{student.Name} ");
                foreach (var homework in context.Homeworks)
                {
                    Console.WriteLine($"{homework.Content} {homework.Type}");
                }
            }
        }
    }
}
