using System;
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements. 
class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Greater is: {0}",Math.Max(a,b));
    }
}

