using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class VawelCount
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Regex regex = new Regex("[AEIOUYaeiouy]");

        int count = regex.Matches(input).Count;
        Console.WriteLine($"Vowels: {count}");
    }
}

