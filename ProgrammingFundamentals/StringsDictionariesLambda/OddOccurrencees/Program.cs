using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string[] input = text.Split(' ');

        var counts = new Dictionary<string, int>();

        foreach (var word in input)
        {
            if (counts.ContainsKey(word))
            {
                counts[word]++;
            }
            else
            {
                counts[word] = 1;
            }
        }
        List<string> list = new List<string>();
        foreach (var pair in counts)
        {
            if (pair.Value %2==1)
            {
                list.Add(pair.Key);
            }
        }
        Console.WriteLine(string.Join(", ",list));
    }
}
