using System;
//Write an expression that checks if given integer is odd or even. 
class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        bool isOdd = n % 2 == 1;
        Console.WriteLine(isOdd);
    }
}

