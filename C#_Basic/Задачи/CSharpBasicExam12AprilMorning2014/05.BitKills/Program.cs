using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string bitNUmber = "";
        string tempNumb = "";
        for (int i = 0; i < n; i++)
        {
            tempNumb = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
            bitNUmber += tempNumb;
        }
        int index = 1;
        char[] bits = bitNUmber.ToCharArray();
        bitNUmber = "";

        for (int i = 0; i < bits.Length; i++)
        {
            if (i == index)
            {
                index += step;
            }
            else
            {
                bitNUmber += bits[i];
            }
        }
        if (bitNUmber.Length % 8 != 0)
        {
            bitNUmber += new string('0', 8 - (bitNUmber.Length % 8));
        }
        for (int i = 0; i < bitNUmber.Length; i+=8)
        {
            string substrigNumber = bitNUmber.Substring(i,8);
            Console.WriteLine(Convert.ToInt32(substrigNumber,2));
        }
    }
}

