using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('&', n / 2 + 1), new string('.', n));
        int outDots = n / 2 - 1;
        int stars = n / 2;
        int inDots = n;
        for (int i = 1; i <= n / 2; i++)
        {

            if (i == n / 2)
            {
                Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', outDots), new string('*', stars), new string('=', inDots));
            }
            else
            {
                Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', outDots), new string('*', stars), new string('.', inDots));
            }
            outDots--;
            stars++;
        }
        outDots = 0;
        stars -= 1;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            outDots++;
            stars--;
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', outDots), new string('*', stars), new string('.', inDots));
        }


        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('&', n / 2 + 1), new string('.', n));
    }
}

