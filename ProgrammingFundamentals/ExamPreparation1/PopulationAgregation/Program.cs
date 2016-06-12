using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        SortedDictionary<string, decimal> countries = new SortedDictionary<string, decimal>();
        Dictionary<string, decimal> cities = new Dictionary<string, decimal>();
        while (true)
        {
            string[] input = Console.ReadLine().Split('\\').ToArray();

            if (input[0] == "stop")
            {
                break;
            }

            var country = Clean(input[0]);
            var town = Clean(input[1]);

            if (!char.IsUpper(country[0]))
            {
                var temp = country;
                country = town;
                town = temp;
            }



        }
    }

    static string Clean(string str)
    {
        string[] validChars = str.Split("@#$&0123456789".ToArray());
        var combined = string.Join("", validChars);
        return combined;
    }
}

