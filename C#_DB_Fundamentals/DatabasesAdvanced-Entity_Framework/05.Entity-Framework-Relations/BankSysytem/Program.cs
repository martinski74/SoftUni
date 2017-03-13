using BankSysytem.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSysytem
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandExecutor executor = new CommandExecutor();
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string output = executor.Execute(input);
                    Console.WriteLine(output);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
