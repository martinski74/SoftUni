using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string sub = Console.ReadLine();
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

