using System;
//Write a program that reads reads a number n (an integer number)
//and p (a bit position). The program should take the bit at position p from number n and copy it to position 2.
//Example: We are given the number 4 and position 0. In binary format,
//4 is 00000100. We take the bit from position 0 – 00000100, and copy it to position 2 - 00000000. Finally, we print the resulting number.

class Program
{
    static void Main()
    {
        string input = Convert.ToString(int.Parse(Console.ReadLine()),2).PadLeft(32,'0');
        int p = int.Parse(Console.ReadLine());

        int[]arr=new int[32];
        for (int i = 0; i < 32; i++) //filling array with binary numbers from input
        {
            arr[i]=input[31-i]-'0';
        }
        if (p!=2)
        {
            arr[2] = arr[p];
        }
        string line = "";
        for (int i = 31; i >=0; i--)
        {
            line += arr[i];
        }
        Console.WriteLine(Convert.ToInt32(line,2));


        //int posToSwap = 2,
        //         mask = 1;

        //// copy bit from position p to mask
        //mask = mask & (n >> p);

        //// nullify bit at position 2
        //n &= ~(1 << posToSwap);

        //// copy mask to bit at position 2
        //n |= mask << posToSwap;

        //Console.WriteLine(n);
    }
}

