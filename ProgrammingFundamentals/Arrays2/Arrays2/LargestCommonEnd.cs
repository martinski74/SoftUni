using System;
using System.Collections.Generic;
using System.Linq;

class LargestCommonEnd
{
    static void Main(string[] args)
    {
        string[] first = Console.ReadLine().Split(' ');
        string[] second = Console.ReadLine().Split(' ');

        int smallerLenght = Math.Min(first.Length,second.Length);
        int leftCounter = 0;
        int rightCounter = 0;
        leftCounter = CheckArrays(first, second, smallerLenght);
        Array.Reverse(first);
        Array.Reverse(second);
        rightCounter = CheckArrays(first, second, smallerLenght);

        Console.WriteLine(Math.Max(leftCounter,rightCounter));
    }

    private static int CheckArrays(string[] first, string[] second, int smallerLenght)
    {
        int counter = 0;
        for (int i = 0; i < smallerLenght; i++)
        {
            if (first[i] == second[i])
            {
                counter++;
            }
            else
            {
                break;
            }
        }
        return counter;
    }
}

