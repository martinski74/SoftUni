using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PlaidTowel
{
    class Program
    {
        static void Main(string[] args)

        {
            int size = int.Parse(Console.ReadLine());
            char background = char.Parse(Console.ReadLine());
            char rhombus = char.Parse(Console.ReadLine());

            for (int row = 0; row < size * 4 + 1; row++)
            {

                for (int col = 0; col < size * 4 + 1; col++)
                {

                    if ((col - row + size) % (size * 2) == 0 || (col + row + size) % (size * 2) == 0)
                    {

                        Console.Write(rhombus);

                    }

                    else
                    {

                        Console.Write(background);

                    }

                }

                Console.WriteLine();

            }
        }
    }
}
