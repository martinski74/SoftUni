using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = n * 3;
        Console.WriteLine("{0}*{0}", new string('.', width / 2));
        int outDots = 1;
        int inDots = width / 2 - 2;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outDots), new string('.', inDots));
            outDots++;
            inDots--;
        }
        for (int i = 0; i < n / 2; i++)
        {
             Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        }

        Console.WriteLine("{0}", new string('*', width));
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        }

        for (int i = 0; i < n - 1; i++)
        {
            outDots--;
            inDots++;
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outDots), new string('.', inDots));
        }


        Console.WriteLine("{0}*{0}", new string('.', width / 2));
    }
}

