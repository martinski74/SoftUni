using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Company name: ");
        string compName = Console.ReadLine();

        Console.Write("Company address: ");
        string compAddress = Console.ReadLine();

        Console.Write("Company fax: ");
        string compFax = Console.ReadLine();

        Console.Write("Company web site: ");
        string webSite = Console.ReadLine();

        Console.Write("Manager first name: ");
        string manFirstName = Console.ReadLine();

        Console.Write("Manager last name: ");
        string manLastName = Console.ReadLine();

        Console.Write("Manager age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Manager phone number: ");
        string manPhoneNum = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Company details.");
        Console.WriteLine("Name:         {0,-20}", compName);
        Console.WriteLine("Address:      {0,-20}", compAddress);
        Console.WriteLine("Fax:          {0,-20}", compFax);
        Console.WriteLine("Web site:     {0,-20}", compFax);
        Console.WriteLine("\nManager details.");
        Console.WriteLine("First name:   {0,-20}", manFirstName);
        Console.WriteLine("Last name:    {0,-20}", manLastName);
        Console.WriteLine("Age:          {0,-20}", age);
        Console.WriteLine("Phone number: {0,-20}", manPhoneNum);
    }
}

