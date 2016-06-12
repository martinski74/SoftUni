using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int resultNumber = 0;
        int counter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int tempCounter = 0;
            foreach (var number in numbers)
            {
                if (numbers[i]== number)
                {
                    tempCounter++;
                }
            }
            if (tempCounter > counter)
            {
                counter = tempCounter;
                resultNumber = numbers[i];
            }
        }
        Console.WriteLine(resultNumber);
    }
}

