using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _03.Manking
{
    public class Startup
    {
        public static void Main()
        {
            try
            {
                var studentInfo = Console.ReadLine().Split(' ');
                var students = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);

                var workerInfo = Console.ReadLine().Split(' ');
                var worker = new Worker(workerInfo[0], workerInfo[1], double.Parse(workerInfo[2]), double.Parse(workerInfo[3]));

                Console.WriteLine(students);
                Console.WriteLine(worker);
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
