using System;

class EmployeeData
{
    static void Main()
    {
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Genger: ");
        char gender = char.Parse(Console.ReadLine());
        Console.Write("ID number: ");
        int idNumber = int.Parse(Console.ReadLine());
        Console.Write("Employee number: ");
        int empoyerNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("First Name : {0}", firstName);
        Console.WriteLine("Last Name : {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID: {0}", idNumber);
        Console.WriteLine("Unique Employee number: {0}", empoyerNumber);
    }
}

