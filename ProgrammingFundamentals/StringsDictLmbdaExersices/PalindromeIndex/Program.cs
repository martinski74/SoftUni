using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        if (Palidrom(text))
        {
            Console.WriteLine("-1");
        }
        else
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (Palidrom(text.Remove(i, 1)))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }

    static bool Palidrom(string word)
    {
        string original = word;
        string reversed = new string(original.Reverse().ToArray());
        bool palinrdom = original == reversed;
        return palinrdom;

    }

}

