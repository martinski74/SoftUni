using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{0}", new string('.', n - 1));
        int outDots = n - 2;
        int midl = 1;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outDots), new string('.', midl));
            outDots--;
            midl += 2;
        }
        Console.WriteLine(new string('*', n * 2 - 1));

        for (int i = 0; i < n / 4; i++)
        {
            Console.WriteLine("*{0}*", new string('.', n * 2 - 3));
        }

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("*{0}{1}{0}*", new string('.', n / 2), new string('*', n - 3));
        }
        for (int i = 0; i < n / 4; i++)
        {
            Console.WriteLine("*{0}*", new string('.', n * 2 - 3));
        }

        Console.WriteLine(new string('*', n * 2 - 1));
    }
}

