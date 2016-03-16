using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        Dictionary<char, int> values = new Dictionary<char, int>()
        { { 'a', 5 },
        { 'b', -12 },
        { 'c', 47 }, 
        { 'd', 7 }, 
        { 'e', -32 } };
        bool noResult = true;
        for (char c1 = 'a'; c1 <= 'e'; c1++)
        {
            for (char c2 = 'a'; c2 <= 'e'; c2++)
            {
                for (char c3 = 'a'; c3 <= 'e'; c3++)
                {
                    for (char c4 = 'a'; c4 <= 'e'; c4++)
                    {
                        for (char c5 = 'a'; c5 <= 'e'; c5++)
                        {
                            string word = "" + c1 + c2 + c3 + c4 + c5;
                            string weightWord = "" + c1;
                            foreach (var ch in word)
                            {
                                if (!weightWord.Contains(ch.ToString()))
                                {
                                    weightWord += ch;
                                }
                            }
                            long currentWeight = Calculate(weightWord, values);
                            if (currentWeight >= start && currentWeight <= end)
                            {
                                Console.Write(word + " ");
                                noResult = false;
                            }
                        }
                    }
                }
            }
        }
        if (noResult)
        {
            Console.WriteLine("No");
        }
    }

    static long Calculate(string word, Dictionary<char, int> values)
    {
        long weight = 0;
        int multiplayer = 1;
        foreach (var curentChar in word)
        {
            weight += multiplayer * values[curentChar];
            multiplayer++;
        }
        return weight;
    }

}

