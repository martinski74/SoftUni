using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int weight = int.Parse(Console.ReadLine());
        int sum = 0;
        int counter = 0;
        for (int a = 0; a < 10; a++)
        {
            for (int b = 0; b < 10; b++)
            {
                for (int c = 0; c < 10; c++)
                {
                    for (int d = 0; d < 10; d++)
                    {
                        for (int x = 0; x < 10; x++)
                        {
                            for (int y = 0; y < 10; y++)
                            {
                               sum = 0;
                                switch (x)
                                {
                                    case 1: sum += 10; break;
                                    case 2: sum += 20; break;
                                    case 3: sum += 30; break;
                                    case 4: sum += 50; break;
                                    case 5: sum += 80; break;
                                    case 6: sum += 110; break;
                                    case 7: sum += 130; break;
                                    case 8: sum += 160; break;
                                    case 9: sum += 200; break;
                                    case 0: sum += 240; break;
                                }
                                switch (y)
                                {
                                    case 1: sum += 10; break;
                                    case 2: sum += 20; break;
                                    case 3: sum += 30; break;
                                    case 4: sum += 50; break;
                                    case 5: sum += 80; break;
                                    case 6: sum += 110; break;
                                    case 7: sum += 130; break;
                                    case 8: sum += 160; break;
                                    case 9: sum += 200; break;
                                    case 0: sum += 240; break;
                                }
                                if (a + b + c + d + sum == weight-40)
                                {
                                    if ( (a == b && b == c && c == d) ||
                                         (a != b && b == c && c == d) ||
                                         (a == b && b == c && c != d) ||
                                         (a == b && b != c && c == d) ||
                                         (a != b && a == c && b == d) ||
                                         (a != b && a == d && b == c))
                                    {
                                        counter++;
                                    }

                                }

                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(counter);
    }
}

