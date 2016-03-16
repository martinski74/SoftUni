using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int sequence = 0;
        int bitCount = 0;
        for (int i = 1, k = 1; i <= n; i++)
        {
            byte currentByte = byte.Parse(Console.ReadLine());
            for (; k < i * 8; k += step)
            {
                int pos = 7 - (k % 8);
                sequence <<= 1;
                sequence |= (currentByte & (1 << pos)) >> pos;
                bitCount++;
                if (bitCount == 8)
                {
                    Console.WriteLine(sequence);
                    sequence = 0;
                    bitCount = 0;
                }
            }
           

        }
        if (bitCount > 0)
        {
            sequence <<= 8 - bitCount;
            Console.WriteLine(sequence);
        }
    }
}

