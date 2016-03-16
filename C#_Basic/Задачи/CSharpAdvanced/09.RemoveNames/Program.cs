using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string firstInputLine = Console.ReadLine();
        string[] firstNames = firstInputLine.Split(' ');
        string secondInputLine = Console.ReadLine();
        string[] secondNames = secondInputLine.Split(' ');

        List<string> firstLine = firstNames.ToList<string>();
        List<string> secondLine = secondNames.ToList<string>();

        for (int i = 0; i < secondLine.Count; i++)
        {
            for (int j = 0; j < firstLine.Count; j++)
            {
                if (firstLine.Contains(secondLine[i]))
                {
                    firstLine.Remove(secondLine[i]);
                }
            }
        }

        foreach (var item in firstLine)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

