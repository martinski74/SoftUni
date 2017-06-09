using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class NonDigitCharacters
{
    public static void Main()
    {
        public string input = Console.ReadLine();

        Regex regex = new Regex("[^0123456789]");

        int count = regex.Matches(input).Count;
        Console.WriteLine($"Non-digits: {count}");
    }
}

