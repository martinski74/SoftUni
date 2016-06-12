using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        decimal waterAmount = decimal.Parse(Console.ReadLine());
        decimal[] bottles = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
        decimal capacity = decimal.Parse(Console.ReadLine());

        List<int>indexes = new List<int>();
        var bottlesLeft = 0;
        decimal littersFilled = 0;

        if (waterAmount % 2==0) // start from left to right
        {
            for (int i = 0; i < bottles.Length; i++)
            {
                littersFilled += capacity - bottles[i];

                if (littersFilled > waterAmount)
                {
                    bottlesLeft++;
                    indexes.Add(i);
                }
            }
        }
        else // start from right to left
        {
            for (int i = bottles.Length - 1; i >= 0; i--)
            {
                littersFilled += capacity - bottles[i];
                if (littersFilled > waterAmount)
                {
                    bottlesLeft++;
                    indexes.Add(i);
                }
            }
        }

        if (littersFilled > waterAmount)
        {
            Console.WriteLine("We need more water!");
            Console.WriteLine("Bottles left: {0}",bottlesLeft);
            Console.WriteLine("With indexes: {0}",string.Join(", ",indexes));
            Console.WriteLine("We need {0} more liters!",littersFilled - waterAmount);
        }
        else
        {
            Console.WriteLine("Enough water!");
            Console.WriteLine("Water left: {0}l.",waterAmount - littersFilled);
        }
    }
}

