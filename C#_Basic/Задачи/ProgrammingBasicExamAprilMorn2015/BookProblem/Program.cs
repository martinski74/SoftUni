using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProblem
{
    class Program
    {
        static void Main()
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int campingDays = int.Parse(Console.ReadLine());
            int pagesPerNormDay = int.Parse(Console.ReadLine());
            int daysOfMonth=30;
            int mothsOfYear = 12;

            if (campingDays==30 || pagesPerNormDay==0)
            {
                Console.WriteLine("never");
                return;
            }
            int normDays = daysOfMonth - campingDays;
            int pagesInNormDay = normDays * pagesPerNormDay;
            int result = (int)Math.Ceiling((double)numberOfPages / pagesInNormDay);

            int years = result / mothsOfYear;
            int months = result % mothsOfYear;
            Console.WriteLine("{0} years {1} months",years,months);
        }
    }
}
