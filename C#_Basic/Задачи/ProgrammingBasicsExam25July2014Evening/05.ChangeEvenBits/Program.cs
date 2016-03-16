using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        int maxHelperNumber = 0;

        for (int i = 0; i < numbersCount; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number > maxHelperNumber)
            {
                maxHelperNumber = number;
            }
        }
        ulong numberToProcess = ulong.Parse(Console.ReadLine());
        string maxHelperStr = Convert.ToString(maxHelperNumber, 2);
        int maxBitCount = maxHelperStr.Length;
        int changedBit = 0;
        for (int position = 0; position < maxBitCount*2; position+=2)
        {
            
            if (GetBitAtPosition(numberToProcess,position)==0)
            {
                changedBit++;
                numberToProcess = SetBitToOne(numberToProcess, position);
            }
           
        }
        Console.WriteLine(numberToProcess);
        Console.WriteLine(changedBit);

    }



    static ulong GetBitAtPosition(ulong n, int position)
    {
        ulong nRightP = n >> position;
        ulong bit = nRightP & 1;
        return bit;
    }
    static ulong SetBitToZero(ulong n, int position)
    {
        ulong mask =(ulong)( ~(1 << position));
        ulong result = n & mask;
        return result;
    }
    static ulong SetBitToOne(ulong n, int position)
    {
        ulong mask =(ulong)(1 << position);
        ulong result = n | mask;
        return result;
    }
}

