using System;
// Write a Boolean expression that returns if the bit at position p (counting from 0, starting from 
//the right) in given integer number n has value of 1. Examples:
class CheckBitAtGivenPosition
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number,2).PadLeft(8,'0'));
        int mask = number >> p;
        bool bit =(mask &1)==1;
        Console.WriteLine(bit);
       
    }
}

