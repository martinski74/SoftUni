using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int bestSequence = 1;
        int currentSeq = 1;
        int bestNumber = 0;

        for (int i = 0; i < numbers.Length-1; i++)
        {
            if (numbers[i]==numbers[i+1])
            {
                currentSeq++;
            }
            else
            {
                currentSeq = 1;
            }
            if (currentSeq >=bestSequence)
            {
                bestSequence = currentSeq;
                bestNumber = numbers[i];
            }
        }

        for (int i = 0; i < bestSequence; i++)
        {
            Console.Write(bestNumber+" "); 
        }
        Console.WriteLine();
    }
}

