using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', n));//first line
        for (int i = 0; i < (n-2)/2; i++)
        {
            string line = new string('-',((n-2)/2)-i);
            string diamond = new string('@',1+(i*2));
            Console.WriteLine("*{0}{1}{0}*",line,diamond);
        }
        for (int i = 0; i <= (n-2)/2; i++)
        {
            string line = new string('-',i);
            string diamond = new string('@', ((n - 2) - (2 * i)));
            Console.WriteLine("*{0}{1}{0}*",line,diamond);
        }


        Console.WriteLine(new string('*', n));//last line
    }
}

