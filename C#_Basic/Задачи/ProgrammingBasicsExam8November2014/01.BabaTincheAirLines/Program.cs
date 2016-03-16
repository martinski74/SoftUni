using System;

class Program
{
    static void Main()
    {
        string[] firstInput = Console.ReadLine().Split();
        string[] secondInput = Console.ReadLine().Split();
        string[] thirdInput = Console.ReadLine().Split();

        int firstClassPass = int.Parse(firstInput[0]);
        int buisinesClassPass = int.Parse(secondInput[0]);
        int economyClassPass = int.Parse(thirdInput[0]);

        int firstClassFrequentFlayers = int.Parse(firstInput[1]);
        int buisinesClassFrequentFlayers = int.Parse(secondInput[1]);
        int economtClassFrequentFlayers = int.Parse(thirdInput[1]);

        int firstClassMeals = int.Parse(firstInput[2]);
        int buisinesClassMeals = int.Parse(secondInput[2]);
        int economyClassMeals = int.Parse(thirdInput[2]);

        double maxPossibleProfit = (12 * 7000 + 12 * (0.005 * 7000)) + (28 * 3500 + 28 * (0.005 * 3500) + 50 * 1000 + 50 * (.005 * 1000));
        double currentProfit = (firstClassPass - firstClassFrequentFlayers) * 7000 +
            (buisinesClassPass - buisinesClassFrequentFlayers) * 3500 +
            (economyClassPass - economtClassFrequentFlayers) * 1000 +
            firstClassFrequentFlayers * 2100 + buisinesClassFrequentFlayers * 1050 + economtClassFrequentFlayers * 300 +
            (firstClassMeals * 7000 * 0.005) + (buisinesClassMeals * 3500 * 0.005) + (economyClassMeals * 1000 * 0.005);

        Console.WriteLine((int)currentProfit);
        Console.WriteLine((int)maxPossibleProfit-(int)currentProfit);
    }
}

