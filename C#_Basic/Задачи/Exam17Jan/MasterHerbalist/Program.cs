using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int dayliExpence = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        int lineCounter = 0;
        int herbCounter = 0;
        int tottalMoney = 0;


        while (input != "Season Over")
        {
            lineCounter++;
            string[] data = input.Split(' ');
            int days = int.Parse(data[0]);
            string midle = data[1];
            int price = int.Parse(data[2]);
           
            if (days <= midle.Length)
            {
                for (int i = 0; i < days; i++)
                {
                    if (midle[i] == 'H')
                    {
                        herbCounter++;
                    }
                }
                tottalMoney += herbCounter * price;
                herbCounter = 0;
            }
            else
            {
                for (int i = 0; i < midle.Length % days; i++)
                {
                    midle = midle + midle[i];
                }
                foreach (var item in midle)
                {
                    if (item == 'H')
                    {
                        herbCounter++;
                    }
                }
                tottalMoney += herbCounter * price;
                herbCounter = 0;

            }




            input = Console.ReadLine();

        }
        decimal avg = (decimal)tottalMoney / lineCounter;
        if (avg >= dayliExpence)
        {
            Console.WriteLine("Times are good. Extra money per day: {0:F2}.", avg - dayliExpence);

        }
        else
        {
            int total = dayliExpence * lineCounter;
            Console.WriteLine("We are in the red. Money needed: {0}.", total - tottalMoney);
        }

    }
}


