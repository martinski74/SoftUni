using System;
using System.Numerics;

class FibonaciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Fib(n);
    }
    static void Fib(int n)
    {
        int a = 0;
        int b = 1;
        int temp=0;
        for (int i = 0; i <= n; i++)
        {
          
            temp = a + b;
            b = a;
            a = temp;

        }
        Console.WriteLine(temp);
        
    }
}

