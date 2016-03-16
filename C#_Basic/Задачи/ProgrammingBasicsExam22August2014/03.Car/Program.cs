using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));

        int outDots = n - 1;
        int inDots = n;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outDots), new string('.', inDots));
            outDots--;
            inDots += 2;
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', n * 2 - 2));

        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine("*{0}*", new string('.', n * 3 - 2));
        }
        Console.WriteLine(new string('*', n * 3));
        outDots = n / 2;
        inDots = n - 2;
        int midlDots = n / 2 - 1;
        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}",new string('.',outDots),new string('.',midlDots),new string('.',inDots));

        }
        Console.WriteLine("{0}{1}{2}{1}{0}",new string('.',n/2),new string('*',n/2+1),new string('.',n-2));
    }
}

