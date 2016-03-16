using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
        int outDots = n - 2;
        int midDots = 0;
        int sreda = n - 2;
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}##{1}#{2}#{1}##{0}",new string('.',outDots)
                ,new string('.',midDots),new string('.',sreda));
            outDots -= 2;
            midDots += 2;
        }
        outDots = 1;
        midDots = n - 3;
        sreda = n - 2;
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.',outDots)
                ,new string('.',midDots),new string('.',sreda));
            outDots += 2;
            midDots -= 2;
        }
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
    }
}

