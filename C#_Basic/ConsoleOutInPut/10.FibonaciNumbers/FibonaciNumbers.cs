using System;
using System.Numerics;
//Write a program that reads a number n and prints on the console the first n members of the 
//Fibonacci sequence (at a single line, separated by spaces) : 
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops.

class FibonaciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger firstNumb = 0;
        BigInteger secondNumb = 1;
        BigInteger temp = 0;
       

        if (n!=1)
        {
            Console.Write(firstNumb + " " + secondNumb);

            for (int i = 2; i < n; i++)
            {
                temp = firstNumb + secondNumb;
                Console.Write(" "+temp);
                firstNumb = secondNumb;
                secondNumb = temp;
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine(firstNumb);
        }
    }
}

