using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char outChar = char.Parse(Console.ReadLine());
        char fillChar = char.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{2}{1}{0}", new string(outChar, n), fillChar, new string(outChar, n * 2 - 1));
        int outDots = n - 1;
        int midDot = 1;
        int sreda = ((n*4)+1)-(outDots*2)-6;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(outChar, outDots), fillChar
                , new string(outChar, midDot), new string(outChar, sreda));
            outDots--;
            midDot += 2;
            sreda -= 2;
        }
        Console.WriteLine("{0}{1}{0}{1}{0}", fillChar, new string(outChar, n * 2 - 1));
        outDots = 1;
        midDot = (((n * 4) + 1) - 7) / 2; 
        sreda = 1;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(outChar, outDots), fillChar
                , new string(outChar, midDot), new string(outChar, sreda));
            outDots++;
            midDot -= 2;
            sreda += 2;
        }

        Console.WriteLine("{0}{1}{2}{1}{0}", new string(outChar, n), fillChar, new string(outChar, n * 2 - 1));
         outDots = n - 1;
         midDot = 1;
         sreda = ((n * 4) + 1) - (outDots * 2) - 6;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(outChar, outDots), fillChar
                , new string(outChar, midDot), new string(outChar, sreda));
            outDots--;
            midDot += 2;
            sreda -= 2;
        }
        Console.WriteLine("{0}{1}{0}{1}{0}", fillChar, new string(outChar, n * 2 - 1));
        outDots = 1;
        midDot = (((n * 4) + 1) - 7) / 2;
        sreda = 1;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(outChar, outDots), fillChar
                , new string(outChar, midDot), new string(outChar, sreda));
            outDots++;
            midDot -= 2;
            sreda += 2;
        }
        Console.WriteLine("{0}{1}{2}{1}{0}", new string(outChar, n), fillChar, new string(outChar, n * 2 - 1));


    }
}

