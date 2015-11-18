using System;

class BankAcountData
{
    static void Main()
    {
        Console.Write("First name: ");
        string firstName = Console.ReadLine();
        Console.Write("midle name: ");
        string middleName = Console.ReadLine();
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Yoyr balance: ");
        decimal balance = decimal.Parse(Console.ReadLine());
        Console.Write("Bank name: ");
        string bankName = Console.ReadLine();
        Console.Write("IBAN: ");
        int IBAN = int.Parse(Console.ReadLine());
        Console.Write("Employee number: ");
        int empoyerNumber = int.Parse(Console.ReadLine());
    }
}

