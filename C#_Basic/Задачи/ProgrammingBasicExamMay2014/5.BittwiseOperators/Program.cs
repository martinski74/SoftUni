using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            int pNew = 0;
            while (num > 0)
            {
                pNew <<= 1;
                int firstBit = num & 1;
                pNew = pNew | firstBit;
                num = num >> 1;
            }

            Console.WriteLine(pNew);
        }

    }
}

