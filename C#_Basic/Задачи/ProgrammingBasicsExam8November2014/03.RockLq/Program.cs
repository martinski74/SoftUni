using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));

        int outDots = n - 2;
        int inerDots = n + 2;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outDots), new string('.', inerDots));
            outDots -= 2;
            inerDots += 4;
        }
        Console.WriteLine("*{0}*{1}*{0}*", new string('.', n - 2), new string('.', n));
        int leftDots=n-4;
        int midlDots=1;
        int inner=n;

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",new string('.',leftDots),new string('.',midlDots),new string('.',inner));

            leftDots -= 2;
            midlDots += 2;
        }

        outDots = n - 1;
        midlDots = n;
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outDots), new string('.', midlDots));
                outDots--;
            midlDots+=2;
        }
        Console.WriteLine(new string('*',n*3));
    }
}

