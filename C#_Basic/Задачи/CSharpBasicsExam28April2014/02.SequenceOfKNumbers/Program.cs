using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputLine = input.Split();
        int k = int.Parse(Console.ReadLine());
        bool print = false;
        string lastNumb = inputLine[0];
        int equalCounter = 1;
        int numbOfElements=0;
        for (int i = 1; i < inputLine.Length; i++)
        {
            if (lastNumb == inputLine[i])
            {
                equalCounter++;
            }
            else
            {
                numbOfElements = equalCounter;
                if (equalCounter >= k)
                {
                    numbOfElements = equalCounter % k;
                }
                for (int j = 0; j < numbOfElements; j++)
                {
                    if (print == false)
                    {
                        Console.Write(lastNumb);
                        print = true;
                    }
                    else
                    {
                        Console.Write(" " + lastNumb);
                    }

                }
                equalCounter = 1;
            }
            lastNumb = inputLine[i];
        }
        numbOfElements = equalCounter;
        if (equalCounter >= k)
        {
            numbOfElements = equalCounter % k;
        }
        for (int j = 0; j < numbOfElements; j++)
        {
            if (print == false)
            {
                Console.Write(lastNumb);
                print = true;
            }
            else
            {
                Console.Write(" " + lastNumb);
            }

        }
    }
}

