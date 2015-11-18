using System;

class ExchangeVariableValue
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine(a);
        Console.WriteLine(b);
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine(a);
        Console.WriteLine(b);

    }
}

