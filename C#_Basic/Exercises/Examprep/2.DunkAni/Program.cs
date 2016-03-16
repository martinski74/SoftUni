using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dot = n;
        int xor = 1;

        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('\'', dot), new string('^', xor));
            dot--;
            xor += 2;
        }
        dot = n - 1;
        xor = 3;
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}",new string('\'',dot),new string('^',xor));
            dot--;
            xor += 2;
        }
        dot = n - 1;
        for (int i = 0; i < n /2 +1; i++)
        {
            Console.WriteLine("{0}| |{0}",new string('\'',dot));
        }
        Console.WriteLine(new string('-',n*2+1));
    }
}

