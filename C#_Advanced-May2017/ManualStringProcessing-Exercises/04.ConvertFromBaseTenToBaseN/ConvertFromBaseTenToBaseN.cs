using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class ConvertFromBaseTenToBaseN
{
    public static void Main()
    {
       
        var nums = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
        int n = (int)nums[0];
        BigInteger number = nums[1];
        BigInteger remainder;
        string result = null;

        if (n >= 2 && n <= 10)
        {
            while (number > 0)
            {
                remainder = number % n;
                number /= n;

                result = remainder.ToString() + result;
            }

            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}

