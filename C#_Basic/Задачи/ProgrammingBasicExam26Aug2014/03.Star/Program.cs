using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{0}", new string('.', n));
        int outDots = n - 1;
        int inDots = 1;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outDots), new string('.', inDots));
            outDots--;
            inDots += 2;
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', n - 1));
        outDots = 1;
        inDots = (n * 2) - 3;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outDots), new string('.', inDots));
            outDots++;
            inDots -= 2;
        }
        Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', n / 2), new string('.', (n / 2) - 1));

        outDots = (n / 2) - 1;
        inDots = (n / 2) - 1;
        int midlDots = 1;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}",new string('.',outDots),new string('.',inDots),new string('.',midlDots));
            outDots--;
            midlDots += 2;
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', n - 1));
    }
}

