using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        input = input.Replace("%","");
        int power = int.Parse(input);
        string programs = Console.ReadLine();

        int programCounter = 0;
       
        while (programs.ToLower()!="end")
        {
            if (power > 15)
            {
                string[] tempProgr = programs.Split('_');
                int percentage =int.Parse(tempProgr[1].Replace("%", ""));
                power = power - percentage;  
            }
            else
            {
                programCounter++;
            }
            
           
            programs = Console.ReadLine();
        }
        if (power <= 0)
        {
            Console.WriteLine("Phone Off");
        }
        else if (power <=15)
        {
            Console.WriteLine("Connect charger -> {0}%",power);
            Console.WriteLine("Programs left -> {0}",programCounter);
        }
        else
        {
            Console.WriteLine("Successful complete -> {0}%", power);
        }
    }
}

