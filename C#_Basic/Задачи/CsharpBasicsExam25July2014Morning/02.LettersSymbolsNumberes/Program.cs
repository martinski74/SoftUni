using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int inputStr = int.Parse(Console.ReadLine());
        int letterSum = 0;
        int digitSum = 0;
        int symbolSum = 0;

        for (int i = 0; i < inputStr; i++)
        {
            string inputLine = Console.ReadLine();
            inputLine = inputLine.ToUpper().Replace(" ", "");

            foreach (var ch in inputLine)
            {
                if (ch >= 'A' && ch <= 'Z')
                {
                    letterSum += (ch - 'A' + 1) * 10;
                }
                else if (ch >= '0' && ch <= '9')
                {
                    digitSum += (ch - '0') * 20;
                }
                else if (ch == '\t' || ch == '\r' || ch == '\n')
                {
                    symbolSum += 0;
                }
                else
                {
                    symbolSum += 200;
                }
            }

        }
        Console.WriteLine(letterSum);
        Console.WriteLine(digitSum);
        Console.WriteLine(symbolSum);
    }
}

