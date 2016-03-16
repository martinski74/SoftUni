using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outIntervals = n / 2 - 1;
        int insideIntervals = n + 1;

        Console.WriteLine("{0}{1}{0}", new string(' ', n / 2), new string('*', n + 1));
        for (int i = 0; i < n / 2 + 1; i++)//top
        {
            Console.WriteLine("{0}*{1}*{0}", new string(' ', n / 2), new string(' ', n - 1));
        }
        if (n > 3)//midle
        {
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string(' ', outIntervals), new string(' ',insideIntervals));
                outIntervals--;
                insideIntervals+=2;
            }
        }

        for (int i = 0; i < n * 2; i++)//body
        {
            if (i < n)
            {
                Console.WriteLine("*{0}*", new string('.', n * 2 - 2));
            }
            else
            {
                Console.WriteLine("*{0}*", new string('@', n * 2 - 2));
            }
        }
        Console.WriteLine(new string('*', n * 2));
    }
}

