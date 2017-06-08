using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MerlahShake
{
    public static void Main()
    {
        var text = Console.ReadLine();
        var pattern = Console.ReadLine();

        var indexOfPattern = text.IndexOf(pattern);

        while (indexOfPattern >= 0 && pattern.Length > 0)
        {
            Console.WriteLine("Shaked it.");

            text = text.Remove(indexOfPattern, pattern.Length);

            var lastIndexOfPattern = text.LastIndexOf(pattern);

            if (lastIndexOfPattern >= 0)
            {
                text = text.Remove(lastIndexOfPattern, pattern.Length);
            }

            pattern = pattern.Remove(pattern.Length / 2, 1);
            indexOfPattern = text.IndexOf(pattern);
        }

        Console.WriteLine("No shake.");
        Console.WriteLine(text);
    }
}

