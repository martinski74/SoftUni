using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outDots = 0;
        int stars = n - 2;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string('.', outDots), new string('*', stars));
            outDots++;
            stars -= 2;
        }

        for (int i = 0; i < n / 2 - ((n < 12) ? 1 : 2); i++)
        {
            Console.WriteLine("{0}||{0}", new string('.', n / 2 - 1));
        }
        for (int i = 0; i < ((n < 12) ? 1 : 2); i++)
        {
            Console.WriteLine(new string('-', n));
        }
    }
}

