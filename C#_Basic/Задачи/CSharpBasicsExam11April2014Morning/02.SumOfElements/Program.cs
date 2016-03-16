using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] numbers = input.Split().Select(int.Parse).ToArray();


        long sum = 0;
        int max=int.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            int curr = numbers[i];
           
            if (curr>max)
            {
                max = curr;
            }
            sum += curr;
        }
        long result = Math.Abs((sum - max) - max);

        if (result==0)
        {
            Console.WriteLine("Yes, sum={0}",max);
        }
        else
        {
            Console.WriteLine("No, diff={0}",result);
        }
    }
}

