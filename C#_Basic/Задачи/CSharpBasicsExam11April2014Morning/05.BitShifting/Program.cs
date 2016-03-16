using System;

class Program
{
    static void Main()
    {
        ulong startNumb = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int result = 0;
        ulong one = 1L;
        for (int i = 0; i < n; i++)
        {
            ulong readNumber = ulong.Parse(Console.ReadLine());
            for (int j = 0; j < 64; j++)
            {
                ulong mask = one << j;
                ulong res = readNumber & mask;
                if (res> 0)
                {
                    startNumb = startNumb & ~mask;
                }
            }
        }
        for (int i = 0; i < 64; i++)
        {
            if ((startNumb & (one << i)) > 0)
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}

