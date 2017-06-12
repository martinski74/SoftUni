using System;
using System.Collections.Generic;

public class SeriesOfLetters
{
    public static void Main()
    {
        string input = Console.ReadLine();

        string result = input[0].ToString();

        for (int i = 0; i < input.Length -1; i++)
        {
            string current = input[i].ToString();
            string next = input[i + 1].ToString();

            if (current == next)
            {
                continue;
            }
            result += next;
        }
        Console.WriteLine(string.Join("",result));
    }
}

