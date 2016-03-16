using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DifferenceBetweenDates
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first dtae:dd.mm.yyyy ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter second dtae:dd.mm.yyyy ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            TimeSpan difference = secondDate - firstDate;
            Console.WriteLine(difference.Days);
        }
    }
}
