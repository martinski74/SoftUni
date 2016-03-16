using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = Array.ConvertAll(input, int.Parse);
        int biggestSum = int.MinValue;
        string currentSequence = "";
        string biggestSumSequence = "";
        int currentSum = 0;
        for (int i = 0; i < numbers.Length; i += 3)
        {
            int firstNum = numbers[i];
            if (i + 2 < numbers.Length)
            {
                int secindNum = numbers[i + 1];
                int tirdNum = numbers[i + 2];
                currentSequence = firstNum + " " + secindNum + " " + tirdNum;
                currentSum = firstNum + secindNum + tirdNum;
                if (currentSum > biggestSum)
                {
                    biggestSum = currentSum;
                    biggestSumSequence = currentSequence;
                }
            }
            else if (i + 2 == numbers.Length)
            {
                int secondNum = numbers[i + 1];
                currentSequence = firstNum + " " + secondNum;
                currentSum = firstNum + secondNum;
                if (currentSum > biggestSum)
                {
                    biggestSum = currentSum;
                    biggestSumSequence = currentSequence;
                }
            }
            else
            {
                currentSequence = firstNum.ToString();
                currentSum = firstNum;
                if (currentSum > biggestSum)
                {
                    biggestSum = currentSum;
                    biggestSumSequence = currentSequence;
                }
            }



        }
        Console.WriteLine(biggestSumSequence);

    }
}

