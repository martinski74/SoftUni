using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long sum1 = 0;
        long sum2 = 0;

        for (int i = 0; i < n; i++)
        {
           sum1 +=  int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            sum2 +=  int.Parse(Console.ReadLine());
        }
        if (sum1==sum2)
        {
            Console.WriteLine("Yes, sum={0}",sum1);
        }
        else
        {
            Console.WriteLine("No, diff={0}",Math.Abs(sum1-sum2));
        }
    }
}

