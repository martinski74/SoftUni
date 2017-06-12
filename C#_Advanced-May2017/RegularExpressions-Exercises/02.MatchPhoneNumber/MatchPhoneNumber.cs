using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class MatchPhoneNumber
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Regex regex = new Regex(@"\+359( |-)2\1\d{3}\1\d{4}\b");

        while (input != "end")
        {
            if (regex.IsMatch(input))
            {
                Console.WriteLine(input);
            }
            input = Console.ReadLine();
        }
    }
}

