using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger firstNumber = 0;
        BigInteger secondNumber = 1;
        BigInteger temp = 0;

        if ((n==1)||(n==2))
        {
            Console.WriteLine(firstNumber);  
        }
           
        else
        {
            Console.Write(firstNumber + " " + secondNumber + " ");
            for (int i = 2; i < n; i++)
            {
                temp = firstNumber+secondNumber;
                firstNumber = secondNumber;
                secondNumber = temp;
                Console.Write(temp+" ");
            }
            Console.WriteLine();
        }
    }
}

