using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        while (input != "END")
        {
            string[] line = input.Trim().Split(' ');
            switch (line[0])
            {
                case "A": phonebook[line[1]] = line[2];
                    break;


                case "S":
                    if (phonebook.ContainsKey(line[1]))
                    {
                        Console.WriteLine("{0} -> {1}", line[1], phonebook[line[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", line[1]);
                    }
                    break;

            }



            input = Console.ReadLine();
        }
    }
}

