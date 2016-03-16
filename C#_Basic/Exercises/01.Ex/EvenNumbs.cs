using System;
//Write a method PrintEvenNumbers() that prints all even numbers in the given range (inclusive).
//•	The method should receive minRange and maxRange as arguments
//•	The method should not return a result
//The numbers should be read from the console.

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        PrintEvenNumbers(n, m);
    }
    static void PrintEvenNumbers(int min, int max)
    {
        for (int i = min; i <= max; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}