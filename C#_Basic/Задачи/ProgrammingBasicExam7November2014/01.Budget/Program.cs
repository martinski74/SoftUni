using System;

class Program
{
    static void Main()
    {
        int amountOfMoney = int.Parse(Console.ReadLine());
        int weekdaysOut = int.Parse(Console.ReadLine());
        int weekendsHomeTown = int.Parse(Console.ReadLine());

        int expanses = weekdaysOut * (int)((0.03 * amountOfMoney) + 10) +
            ((22 - weekdaysOut) * 10) + ((4 - weekendsHomeTown) * 2 * 20) + 150;


        if (amountOfMoney > expanses)
        {
            Console.WriteLine("Yes, leftover {0}.", amountOfMoney - expanses);
        }
        else if (amountOfMoney < expanses)
        {
            Console.WriteLine("No, not enough {0}.", expanses - amountOfMoney);
        }
        else
        {
            Console.WriteLine("Exact Budget.");
        }

    }
}

