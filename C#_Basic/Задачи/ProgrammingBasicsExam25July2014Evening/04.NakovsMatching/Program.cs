using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();
        int maxWeight = int.Parse(Console.ReadLine());
        bool resultFound = false;

        for (int div1 = 1; div1 < firstWord.Length; div1++)
        {
            for (int div2 = 1; div2 < secondWord.Length; div2++)
            {
                string firstLeft = firstWord.Substring(0,div1);
                string firstRight = firstWord.Substring(div1);
                string secondtLeft = secondWord.Substring(0,div2);
                string secondRight = secondWord.Substring(div2);

                long firstLeftWeight = CalculateWeight(firstLeft);
                long firstRightWeight = CalculateWeight(firstRight);
                long secondLeftWeigt = CalculateWeight(secondtLeft);
                long secondRightWeigt = CalculateWeight(secondRight);

                long nakovWeight = Math.Abs(firstLeftWeight * secondRightWeigt - secondLeftWeigt * firstRightWeight);

                if (nakovWeight <= maxWeight)
                {
                    resultFound = true;
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs",
                        firstLeft,firstRight,secondtLeft,secondRight,nakovWeight);

                }
            }
        }
        if (!resultFound)
        {
            Console.WriteLine("No");
        }
    }
    static long CalculateWeight(string word)
    {
        int sum = 0;
        for (int i = 0; i < word.Length; i++)
        {
            sum += (int)word[i]; 
        }

        return sum;
    }

}

