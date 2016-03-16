using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{0}", new string("-", n / 2));
        int outDash = n / 2 - 1;
        int inDash = 1;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",new string("-",outDash),new string("-",inDash));
            outDash--;
            inDash += 2;
        }
        outDash = 1;
        inDash = n-4;
        for (int i = 0; i < n/2-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",new string("-",outDash),new string("-",inDash));
            outDash++;
            inDash -= 2;
        }

        Console.WriteLine("{0}*{0}", new string("-", n / 2));
    }
}

