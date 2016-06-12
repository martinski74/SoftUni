using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rotations = int.Parse(Console.ReadLine());

        int[] sumOfRatations = new int[numbers.Length];

        for (int curRotation = 0; curRotation < rotations; curRotation++)
        {
            int lastEllements = numbers[numbers.Length - 1];

            for (int curentEl = numbers.Length-1; curentEl > 0; curentEl--)
            {
                numbers[curentEl] = numbers[curentEl - 1];
 
            }
            numbers[0] = lastEllements;
            for (int i = 0; i < numbers.Length; i++)
            {
                sumOfRatations[i] += numbers[i];
            }
        }

        Console.WriteLine(string.Join(" ",sumOfRatations));


    }
}

