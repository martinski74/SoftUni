using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        string[] date = input[0].Split('.');
        string name = input[1];

        int days = int.Parse(date[0]);
        int months = int.Parse(date[1]);
        int years = int.Parse(date[2]);

        long result = days * months * years;
        if (months % 2 != 0)
        {
            result *= result;
        }

        for (int i = 0; i < name.Length; i++)
        {
            char currLetter = name[i];
            if (currLetter >= 'a' && currLetter <= 'z')
            {
                result += currLetter - 'a' + 1;
            }
            else if (currLetter >= 'A' && currLetter <= 'Z')
            {
                result += 2 * (currLetter - 'A' + 1);
            }
            else if (currLetter >= '0' && currLetter <= '9')
            {
                result += currLetter - '0';
            }

        }
        while (result > 13)
        {
            int digitSum = 0;

            while (result > 0)
            {
                digitSum += (int)(result % 10);
                result = result / 10;
            }
            result = digitSum;
           
        }
        Console.WriteLine(result);



    }
}
