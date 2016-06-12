using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        for (int i = 0; i < first.Length; i++)
        {
            string common1 = first.Substring(i,1);

            for (int j = 0; j < second.Length; j++)
            {
                string common2 = second.Substring(j,1);
                if (common1 == common2)
                {
                    Console.WriteLine("yes");
                    return;
                }
            }
        }
        Console.WriteLine("no");
    }
}

