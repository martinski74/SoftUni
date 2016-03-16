using System;

class Program
{
    static void Main()
    {
        uint rubli = uint.Parse(Console.ReadLine());
        uint dolars = uint.Parse(Console.ReadLine());
        uint euro = uint.Parse(Console.ReadLine());
        uint bLeva = uint.Parse(Console.ReadLine());
        uint mLeva = uint.Parse(Console.ReadLine());

        decimal R = (rubli / 100M * 3.5M);
        decimal D = (dolars * 1.5M);
        decimal E = (euro * 1.95M);
        decimal BLV = (bLeva / 2M);

        Console.WriteLine("{0:F2}",Math.Ceiling(Math.Max(R,Math.Max(D,Math.Max(E,Math.Max(BLV,mLeva))))));
    }
}

