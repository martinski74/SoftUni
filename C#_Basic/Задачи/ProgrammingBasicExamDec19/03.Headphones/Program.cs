using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new string('-', n / 2), new string('*', n + 2));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', n / 2), new string('-', n));

        }
        int outDash = n / 2 - 1;
        int stars = 3;
        int inerDash = n - 2;
        for (int i = 0; i < n - 2; i++)
        {
            if (i < n / 2 - 1)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outDash), new string('*', stars), new string('-', inerDash));
                outDash--;
                stars += 2;
                inerDash -= 2;
            }
            else
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outDash), new string('*', stars), new string('-', inerDash));
                outDash++;
                stars -= 2;
                inerDash += 2;
            }
            

        }
        Console.WriteLine("{0}*{1}*{0}",new string('-',n/2),new string('-',n));
    }
}

