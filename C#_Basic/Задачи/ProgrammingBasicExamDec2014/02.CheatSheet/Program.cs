using System;

class Program
{
    static void Main()
    {
        long row = long.Parse(Console.ReadLine());
        long col = long.Parse(Console.ReadLine());
        long h = long.Parse(Console.ReadLine());
        long v = long.Parse(Console.ReadLine());

        for (long i = h; i < h + row; i++)
        {
            for (long j = v; j < v + col; j++)
            {
                Console.Write(i*j+" ");
            }
            Console.WriteLine();
        }
    }
}

