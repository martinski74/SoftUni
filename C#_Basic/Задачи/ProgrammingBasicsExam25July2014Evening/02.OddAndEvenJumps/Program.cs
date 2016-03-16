using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());

        char[] inputCharArr = input.ToCharArray();
        input = input.Replace(" ","").ToLower();

        long oddSum = 0;
        int evenSum = 0;
        int totalSum = 0;
        int oddCount = 1;
        int evenCount = 1;
        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0)//odd
            {
                if (oddCount % oddJump != 0)
                {
                    oddSum += input[i];
                }
                else
                {
                    oddSum *= input[i];
                }
                oddCount++;
            }
            else
            {
                if (evenCount % evenJump != 0)
                {
                    evenSum += input[i];
                }
                else
                {
                    evenSum *= input[i];
                }
                evenCount++;
            }
        }

        Console.WriteLine("Odd: {0:X}",oddSum);
        Console.WriteLine("Even: {0:X}",evenSum);
    }
}

