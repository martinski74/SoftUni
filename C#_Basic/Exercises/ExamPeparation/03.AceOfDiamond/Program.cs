using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AceOfDiamond
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n));
            int dashes = n / 2 - 1;
            int eta = 1;
            for (int i = 0; i <= (n-2)/2; i++)
            {
               
                Console.WriteLine("*{0}{1}{0}*",new string('-',dashes),new string('@',eta));
                dashes--;
                eta += 2;
               
            }
            dashes = 1;
            eta = n - 2 - 2;
            for (int i = 0; i < (n-2)/2; i++)
            {
               Console.WriteLine("*{0}{1}{0}*",new string('-',dashes),new string('@',eta));
                dashes++;
                eta -= 2;  
            }

            Console.WriteLine(new string('*', n));
        }
    }
}
