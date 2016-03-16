using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int fPosition = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());

        char[] bits = Convert.ToString(n,2).PadLeft(19,'0').ToCharArray();
        //Console.WriteLine(bits);
        fPosition = 19 - 1 - fPosition;

        for (int i = 0; i < r; i++)
        {
            char[]newBits=new char[bits.Length];
            for (int pos = 0; pos < bits.Length; pos++)
            {
                if (pos==fPosition)
                {
                    newBits[pos] = bits[pos];
                }
                else
                {
                    int newPos = (pos + 1) % bits.Length;
                    if (newPos==fPosition)
                    {
                        newPos = (newPos + 1) % bits.Length;
                    }
                    newBits[newPos] = bits[pos];
                }
            }
            for (int j = 0; j < bits.Length; j++)
            {
                bits[j] = newBits[j];
            }
        }
        int result = Convert.ToInt32(new string(bits),2);
        Console.WriteLine(result);
    }
}

