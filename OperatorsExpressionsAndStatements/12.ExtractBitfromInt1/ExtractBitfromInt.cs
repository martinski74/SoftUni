using System;
//Write an expression that extracts from given integer n the value of given bit at index p. 
class ExtractBitfromInt
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = n >> p ;
        int bit = mask & 1;
        Console.WriteLine(bit);
    }
}

