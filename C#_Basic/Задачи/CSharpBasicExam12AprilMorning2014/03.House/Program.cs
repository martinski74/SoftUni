using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{0}", new string('.', n / 2));
        int outDots = n / 2 - 1;
        int midDots = 1;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outDots), new string('.', midDots));
            outDots--;
            midDots += 2;
        }
        Console.WriteLine(new string('*', n));
        outDots = n / 4;

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outDots), new string('.', n - 2 * (n / 4) - 2));

        }
        Console.WriteLine("{0}{1}{0}", new string('.', n / 4), new string('*', n - 2 * (n / 4)));
    }
}

