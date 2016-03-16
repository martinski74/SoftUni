using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string command = Console.ReadLine();
        while (command != "start" && command != "START")
        {
            command = Console.ReadLine();
        }
        command = Console.ReadLine();

        int counter = 0;
        string encripted = "";

        while (command != "end" && command != "END")
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                command = Console.ReadLine();
                continue;
            }
            for (int i = command.Length-1; i >= 0; i--)
            {
                char currentSymbol = command[i];
                if ((currentSymbol >= 'a' && currentSymbol <= 'm') || (currentSymbol >= 'A' && currentSymbol <= 'M'))
                {
                    encripted += (char)(currentSymbol + 13);
                }
                else if ((currentSymbol >= 'n' && currentSymbol <= 'z') || (currentSymbol >= 'M' && currentSymbol <= 'Z'))
                {
                    encripted += (char)(currentSymbol - 13);
                }
                else if (currentSymbol >= '0' && currentSymbol <= '9')
                {
                    encripted += currentSymbol;
                }
                else
                {
                    switch (currentSymbol)
                    {
                        case '+': encripted += ' '; break;
                        case '%': encripted += ','; break;
                        case '&': encripted += '.'; break;
                        case '#': encripted += '?'; break;
                        case '$': encripted += '!'; break;
                    }
                }
            }
            counter++;
            encripted += "\n";


            command = Console.ReadLine();
        }
        if (counter==0)
        {
           Console.WriteLine("No message received."); 
        }
        else
        {
            Console.WriteLine("Total number of messages: {0}", counter);
            Console.WriteLine(encripted);
        }
       
    }
}

