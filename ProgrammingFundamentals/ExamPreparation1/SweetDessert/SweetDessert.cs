using System;

class Program
{
    static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        int numbGuests = int.Parse(Console.ReadLine());
        decimal bananasPrice = decimal.Parse(Console.ReadLine());
        decimal eggsPrice = decimal.Parse(Console.ReadLine());
        decimal beriesPrice = decimal.Parse(Console.ReadLine());

        decimal sets = numbGuests / 6;
        if (numbGuests % 6 != 0)
        {
            sets++;
        }
        decimal needetProducts = sets * (2 * bananasPrice) + sets * (4 * eggsPrice) + sets * (0.2m * beriesPrice);
        if (needetProducts <= cash)
        {
            Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.",needetProducts);
        }
        else
        {
            Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.",Math.Abs(needetProducts - cash));
        }
    }
}

