using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class ValidUsernames
{
    public static void Main()
    {
        string input = Console.ReadLine();

        string patern = @"^[\w\d-]{3,16}$";
        Regex regex = new Regex(patern);
        while (input != "END")
        {
            MatchCollection matches = regex.Matches(input);
            if (matches.Count > 0)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
            input = Console.ReadLine();
        }
    }
}

