using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int outPoint = n - 1;
        int asteriks = 1;
        int rightPoints = n;

        for (int i = 0; i < n; i++)
        {
            if (i < n / 2)
            {
                Console.WriteLine("{0}{1}{2}", new string('.', outPoint), new string('*', asteriks), new string('.', rightPoints));
                outPoint -= 2;
                asteriks += 2;
            }
            else
            {
                Console.WriteLine("{0}{1}{2}", new string('.', outPoint), new string('*', asteriks), new string('.', rightPoints));
                outPoint += 2;
                asteriks -= 2;
            }


        }

        int dots = 0;
        int asterix = n * 2;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}",new string('.',dots),new string('*',asterix));
            dots++;
            asterix-=2;

        }



    }
}

