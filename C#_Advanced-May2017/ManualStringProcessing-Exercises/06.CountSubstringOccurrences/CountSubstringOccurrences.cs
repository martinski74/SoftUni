using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CountSubstringOccurrences
{
    public static void Main()
    {
        var text = Console.ReadLine().ToLower();
        var sub = Console.ReadLine();
        int counter = 0;
        int startPos = 0;

        while (true)
        {
            int pos = text.IndexOf(sub,startPos);
            if (pos == -1)
            {
                break;
            }
            startPos = pos + 1;
            counter++;
        }
        Console.WriteLine(counter);
    }
}

