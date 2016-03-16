using System;

class Program
{
    static void Main()
    {
        double priceOfTv = double.Parse(Console.ReadLine());
        int years = int.Parse(Console.ReadLine());
        double bankInterst = double.Parse(Console.ReadLine());
        double friendInterst = double.Parse(Console.ReadLine());

        double pow=(1d+bankInterst);
        double loan = (double)Math.Pow(pow,years);

        double bankLoan = priceOfTv * loan;
        double friendLoan=priceOfTv*(1+friendInterst);
        double bestPrice=Math.Min(bankLoan,friendLoan);
        string bestLoan = bankLoan < friendLoan ? "Bank" : "Friend";
        Console.WriteLine("{0:F2} {1}",bestPrice,bestLoan);
    }
}

