using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dashes = n / 2;
        int stars = 1;
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}",new string('-',dashes),new string('*',stars));
            dashes--;
            stars += 2;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("|{0}|",new string('*',n-2)); 
        }
    }
}

