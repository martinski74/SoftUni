using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = numbers.Length / 4;

        int[] midleElement = new int[2 * k];



        for (int i = 0; i < midleElement.Length; i++)
        {
            midleElement[i] = numbers[k + i];
        }

        int[] firstKElements = new int[k];
        for (int i = 0; i < firstKElements.Length; i++)
        {
            firstKElements[i] = numbers[i];
        }
        int[] lastKeyElements = new int[k];
        for (int i = 0; i < lastKeyElements.Length; i++)
        {
            lastKeyElements[i] = numbers[i + 3 * k];
        }
        Array.Reverse(lastKeyElements);
        Array.Reverse(firstKElements);

        int[] firstAndLastElements = new int[k * 2];

        for (int i = 0; i < firstAndLastElements.Length; i++)
        {
            if (i < k)
            {
                firstAndLastElements[i] = firstKElements[i]; 
            }
            else
            {
                firstAndLastElements[i] = lastKeyElements[i - k];
            }
        }
        for (int i = 0; i < midleElement.Length; i++)
        {
            midleElement[i] += firstAndLastElements[i];
        }
        Console.WriteLine(string.Join(" ",midleElement));


    }
}

