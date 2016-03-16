using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.EncryptMessge
{
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
            string encrypted = "";

            while (command != "end" && command != "END")
            {
                if (String.IsNullOrWhiteSpace(command))
                {
                    command = Console.ReadLine();
                    continue;
                }
                for (int i = command.Length-1; i >= 0; i--)
                {
                    char currSymbol = command[i];
                    if ((currSymbol >= 'a' && currSymbol <= 'm') || ((currSymbol >= 'A' && currSymbol <= 'M')))
                    {
                        encrypted += (char)(currSymbol + 13);
                    }
                    else if ((currSymbol >= 'n' && currSymbol <= 'z') || ((currSymbol >= 'N' && currSymbol <= 'Z')))
                    {
                        encrypted += (char)(currSymbol - 13);
                    }
                    else if (currSymbol >= '0' && currSymbol <= '9')
                    {
                        encrypted += currSymbol;
                    }
                    else
                    {
                        switch (currSymbol)
                        {
                            case ' ': encrypted += '+'; break;
                            case ',': encrypted += '%'; break;
                            case '.': encrypted += '&'; break;
                            case '?': encrypted += '#'; break;
                            case '!': encrypted += '$'; break;
                        }
                    }

                }
                counter++;
                encrypted += Environment.NewLine;

                command = Console.ReadLine();
            }
           
            if (counter == 0)
            {
                Console.WriteLine("No messages sent.");
            }
            else
            {
                
                Console.WriteLine("Total number of messages: {0}",counter);
               
                Console.WriteLine(encrypted.ToString());
               
            }
        }
    }
}
