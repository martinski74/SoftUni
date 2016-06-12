using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal totalProfit = 0;

        for (int i = 0; i < n; i++)
        {

            int adultPassangers = int.Parse(Console.ReadLine());
            decimal adultPrice = decimal.Parse(Console.ReadLine());
            int youthPassanger = int.Parse(Console.ReadLine());
            decimal youthPrice = decimal.Parse(Console.ReadLine());
            decimal fuelPrice = decimal.Parse(Console.ReadLine());
            decimal fuelConsum = decimal.Parse(Console.ReadLine());
            decimal flightDuration = decimal.Parse(Console.ReadLine());

            decimal incom = (adultPassangers * adultPrice) + (youthPassanger * youthPrice);
            decimal expence = flightDuration * fuelConsum * fuelPrice;

            decimal profit = incom - expence;
            totalProfit += profit;

            if (incom >= expence)
            {
                Console.WriteLine("You are ahead with {0:f3}$.",profit);
            }
            else
            {
                Console.WriteLine("We've got to sell more tickets! We've lost {0:f3}$.",profit);
            }

           

        }
        Console.WriteLine("Overall profit -> {0:f3}$.",totalProfit);
        Console.WriteLine("Average profit -> {0:f3}$.",totalProfit/n);
        
    }
}

