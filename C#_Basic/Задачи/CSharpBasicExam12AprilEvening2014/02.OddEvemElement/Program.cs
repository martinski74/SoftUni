using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
    
        string numbers = Console.ReadLine();
        string[] input = numbers.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
        decimal oddSum = 0;
        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue;

        decimal evenSum = 0;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue;
        //if (numbers == "")
        //{
        //    input = new string[0];
        //}

        for (int i = 0; i < input.Length; i += 2)//odd elements
        {
            decimal currentNUmb = decimal.Parse(input[i]);
            oddSum += currentNUmb;
            if (currentNUmb < oddMin)//min number
            {
                oddMin = currentNUmb;
            }
            if (currentNUmb > oddMax)
            {
                oddMax = currentNUmb;
            }
        }
        for (int i = 1; i < input.Length; i += 2)//even elements
        {
            decimal currentNUmb = decimal.Parse(input[i]);
            evenSum += currentNUmb;
            if (currentNUmb < evenMin)
            {
                evenMin = currentNUmb;
            }
            if (currentNUmb > evenMax)
            {
                evenMax = currentNUmb;
            }
        }
        if (input.Length == 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (input.Length == 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No"
                , (double)oddSum, (double)oddMin, (double)oddMax);
        }
        else if (input == null)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}"
                      , "No", "No", "No",
                      "No", "No", "No");
        }
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}"
          , (double)oddSum, (double)oddMin, (double)oddMax,
          (double)evenSum, (double)evenMin, (double)evenMax);
        }

    }
}

