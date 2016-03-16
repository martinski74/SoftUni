using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string bitSeq = "";
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string currentSeq = "";
            for (int j = 0; j < 8; j++)
            {
                int lastDig = (number & (1 << j)) >> j;
                currentSeq = lastDig + currentSeq;
            }
            bitSeq += currentSeq;
        }
        char[] digits = bitSeq.ToCharArray();
        for (int i = 0; i < digits.Length; i++)
        {
            int position = 1 + i * step;

            if (position > digits.Length-1)
            {
                break;
            }
            digits[position] = '1';

        }
        string currNumber = "";
        for (int i = 0; i < digits.Length; i++)
        {
            currNumber += digits[i];
            if ((i +1)% 8 == 0)
            {
                int result = Convert.ToInt32(currNumber,2);
                Console.WriteLine(result);
                currNumber = "";
            }
        }

    }
}

