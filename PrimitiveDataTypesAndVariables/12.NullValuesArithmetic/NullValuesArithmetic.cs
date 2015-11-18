using System;

class NullValuesArithmetic
{
    static void Main()
    {
        double? num = null;
        int? sum = null;
        Console.WriteLine(num);
        Console.WriteLine(sum);
        int? secSum = null;
        num = 5d;
        sum = secSum;
        Console.WriteLine(num);
        Console.WriteLine(sum);
    }
}

