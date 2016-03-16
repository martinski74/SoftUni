using System;
//Write a program that reads two positive integer numbers and prints how many numbers 
//p exist between them such that the reminder of the division by 5 is 0.
class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        int p = 0;

        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                p++;
                Console.Write(i+", ");
            }
        }
        Console.WriteLine("\n{0}",p);

    }
}

