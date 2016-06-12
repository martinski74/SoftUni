using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool isFound = false;
        for (int currentEle = 0; currentEle < numbers.Length; currentEle++)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int i = currentEle+1; i < numbers.Length; i++)
            {
                rightSum += numbers[i];
            }
            for (int i = 0; i < currentEle; i++)
            {
                leftSum += numbers[i];
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine(currentEle);
                isFound = true;
                break;
            }
        }
        if (!isFound)
        {
            Console.WriteLine("no");
        }
    }
}

