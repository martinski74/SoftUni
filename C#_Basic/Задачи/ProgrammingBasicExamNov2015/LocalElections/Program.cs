using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int vote = int.Parse(Console.ReadLine());
        string symbol = Console.ReadLine();
        Console.WriteLine(new string('.', 13));
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("...+{0}+...", new string('-', 5));
            if (i == vote)
            {
                if (symbol.ToLower()=="x")
                {
                    Console.WriteLine("...|.\\./.|...");
                    Console.WriteLine("{0}.|..{1}..|...",i.ToString().PadLeft(2,'0'),symbol.ToUpper());
                    Console.WriteLine("...|./.\\.|...");
                }
                else
                {
                    Console.WriteLine("...|\\.../|...");
                    Console.WriteLine("{0}.|.\\./.|...", i.ToString().PadLeft(2, '0'), symbol);
                    Console.WriteLine("...|..V..|...");
                }
            }
            else
            {
                Console.WriteLine("...|.....|...");
                Console.WriteLine("{0}.|.....|...",i.ToString().PadLeft(2,'0'));
                Console.WriteLine("...|.....|...");
            }

            Console.WriteLine("...+{0}+...", new string('-', 5));
            Console.WriteLine(new string('.', 13));
        }


       

    }
}

