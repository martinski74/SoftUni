using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        string input = Console.ReadLine();
        while (input != "print")
        {
            string[] token = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string command = token[0];
            switch (command)
            {
                case "add": int index = int.Parse(token[1]);
                    int element = int.Parse(token[2]);
                    if (index >= 0 && index <= numbers.Count)
                    {
                        numbers.Insert(index, element);
                    }
                    break;

                case "addMany": List<int> manyNumbers = new List<int>();
                    for (int i = 2; i < token.Length; i++)
                    {
                        manyNumbers.Add(int.Parse(token[i]));
                    }
                    index = int.Parse(token[1]);
                    if (index >= 0 && index <= numbers.Count)
                    {
                        numbers.InsertRange(index, manyNumbers);
                    }
                    break;

                case "contains": int elemnt = int.Parse(token[1]);
                    Console.WriteLine(numbers.IndexOf(elemnt));
                    break;

                case "remove": index = int.Parse(token[1]);
                    if (index >= 0 && index <= numbers.Count)
                    {
                        numbers.RemoveAt(index);
                    }
                    break;

                case "shift": int pos = int.Parse(token[1]);
                    for (int i = 0; i < pos % numbers.Count; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                    break;

                case "sumPairs": if (numbers.Count % 2 == 0)
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i] += numbers[i + 1];
                            numbers.RemoveAt(i + 1);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < numbers.Count - 1; i++)
                        {
                            numbers[i] += numbers[i + 1];
                            numbers.RemoveAt(i + 1);
                        }
                    }

                    break;

            }

            input = Console.ReadLine();
        }
        Console.WriteLine("[{0}]",string.Join(", ", numbers));
    }
}

