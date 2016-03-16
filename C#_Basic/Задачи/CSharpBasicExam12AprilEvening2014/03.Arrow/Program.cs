using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('.', n / 2)+ new string('#', n)+ new string('.', n / 2));
        int outDots = n / 2;
        int midDots = n - 2;
        for (int i = 0; i < n-2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}",new string('.',outDots),new string('.',midDots));

        }
        Console.WriteLine("{0}{1}{0}",new string('#',n/2+1),new string('.',n-2));
        outDots = 1;
        int width = n * 2 - 1;
        midDots = width - 4;

        for (int i = 0; i < n-2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}",new string('.',outDots),new string('.',midDots));
            outDots++;
            midDots -= 2;
        }
        Console.WriteLine(new string('.',n-1)+"#"+new string('.',n-1));
    }
}

