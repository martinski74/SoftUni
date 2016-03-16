using System;
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the
//value v at the position p from the binary representation of n while preserving all other bits in n. Examples:
class ModifyBitAtGivenPos
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.Write("Enter position of bit: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter value of bit(1 or 0): ");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine();


        if (value == 0)
        {
            int mask = ~(1 << p);
            int setBit = number & mask;
            Console.WriteLine(Convert.ToString(setBit,2).PadLeft(16,'0'));
            Console.WriteLine(setBit);
        }
        else
        {
            int mask = 1 << p;
            int setBit1 = number | mask;
            Console.WriteLine(Convert.ToString(setBit1,2).PadLeft(16,'0'));
            Console.WriteLine(setBit1);
        }
    }
}

