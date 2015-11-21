using System;
//Write a program that reads 3 real numbers from the console and prints their sum. 
class SumOfTreeNumbers
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        double sum = a + b + c;
        Console.WriteLine(sum);
    }
}

