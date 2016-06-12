using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] text = input.Split(new char[]{' ', '.', ',', '?', '!'}
            ,StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();
        List<string> sorted = new List<string>();

        for (int i = 0; i < text.Length; i++)
        {
            if (Palidrom(text[i]))
            {
                sorted.Add(text[i]);
            } 
        }
        sorted.Sort();
        Console.WriteLine(string.Join(", ",sorted));
    }

     static bool Palidrom(string word)
    {
        string original = word;
        string reversed = new string(original.Reverse().ToArray());
        bool palinrdom = original == reversed;
        return palinrdom;

    }

}

