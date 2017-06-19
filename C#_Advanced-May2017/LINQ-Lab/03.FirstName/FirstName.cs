using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FirstName
{
    public static void Main()
    {
        string[] names = Console.ReadLine().Split(' ');
        string[] letters = Console.ReadLine().Split(' ').OrderBy(x => x).ToArray();

        foreach (var letter in letters)
        {
            string result = names.Where(w => w.ToLower()
            .StartsWith(letter.ToLower()))
            .FirstOrDefault();

            if (result != null)
            {
                Console.WriteLine(result);
                return;                    
            }
        }

        Console.WriteLine("No match");
    }
}

