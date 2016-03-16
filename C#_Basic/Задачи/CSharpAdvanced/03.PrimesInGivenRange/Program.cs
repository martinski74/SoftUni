using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.PrimesInGivenRange
{
    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int count = 0;
            FindPrimesInRange(start, end, count);
        }

        private static void FindPrimesInRange(int n, int m, int count)
        {
            List<int> numbers = new List<int>();
            if (n == 0 || n == 1)
            {
                n = 2;
            }
            if (n > m)
            {
                Console.WriteLine("Empty list");
            }
            for (int i = n; i <= m; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                    if (count > 2)
                    {
                        break;
                    }
                }
                if (count <=2)
                {
                    numbers.Add(i);
                }
                count = 0;
            }
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


        }


    }
}
