using EntityFramework_CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an option: ");
        Console.WriteLine("------------------");
        Console.WriteLine("1. Define a class Person");
        Console.WriteLine(" (Create and Print Gosho, Pesho and Stamat)");
        Console.WriteLine("2. Create Person Constructors");
        Console.WriteLine("3. Oldest Family Member");
        Console.WriteLine("4. Students");
        Console.WriteLine("5. Planck Constant");
        Console.WriteLine("6. Math Utilities");
        Console.WriteLine();
        Console.Write("Your choise is: ");
        int option = 0;

        try
        {
            option = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("You need to enter a number.");
        }

        switch (option)
        {
            case 1: CreatePersons(); break;
            case 2: CreateConstructors(); break;
            case 3: OldestFamilyMember(); break;
            case 4: Students(); break;
            case 5: PlanckConstant(); break;
            case 6: MathUtilities(); break;
            default: break;
        }
    }

    private static void MathUtilities()
    {
        Console.WriteLine("Enter comands (Example: Sum 5 5):");
        Console.WriteLine("For end enter 'End'");
        string input = "";

        while (input != "End")
        {
            input = Console.ReadLine();
            if (input != "End")
            {
                string[] arg =
            input.Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries).ToArray();
                double arg1 = double.Parse(arg[1]);
                double arg2 = double.Parse(arg[2]);
                double result = 0;
                switch (arg[0])
                {
                    case "Sum":
                        result = MathUtil.Sum(arg1, arg2); break;
                    case "Subtract":
                        result = MathUtil.Subtract(arg1, arg2); break;
                    case "Multiply":
                        result = MathUtil.Multiply(arg1, arg2); break;
                    case "Divide":
                        result = MathUtil.Divide(arg1, arg2); break;
                    case "Percentage":
                        result = MathUtil.Percantige(arg1, arg2); break;
                    default: Console.WriteLine("Error"); break;
                }
                Console.WriteLine("{0:0.00}", result);
            }
        }
    }

    private static void PlanckConstant()
    {
        Console.WriteLine(Calculation.Result());
    }

    private static void Students()
    {
        Console.WriteLine("Enter the student names one by row:");
        Console.WriteLine("For end type 'end'");
        string input = Console.ReadLine();
        while (input != "end")
        {
            Student st = new Student(input);
            input = Console.ReadLine();
        }
        Console.WriteLine(Student.count);
    }

    private static void OldestFamilyMember()
    {
        Family f = new Family();
        Console.Write("Number of persons: ");
        int count = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the input (Example: Gosho 23): ");
        for (int i = 1; i <= count; i++)
        {
            string[] inputArgs =
            Console.ReadLine().Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);
            Person p = new Person(inputArgs[0],
                int.Parse(inputArgs[1]));
            f.AddMember(p);
        }
        Console.WriteLine($"{f.GetOldestPerson().Name} " +
            $"{f.GetOldestPerson().Age}");
    }

    private static void CreateConstructors()
    {
        Console.Write("Input: ");
        string[] inputArgs =
            Console.ReadLine().Split(new char[] { ',' },
            StringSplitOptions.RemoveEmptyEntries);

        if (inputArgs.Length == 0)
        {
            Person p = new Person();
            Console.WriteLine($"{p.Name} {p.Age}");

        }
        else if (inputArgs.Length == 1)
        {
            string argument = inputArgs[0];
            int age = -1;
            if (int.TryParse(argument, out age))
            {
                Person p = new Person(age);
                Console.WriteLine($"{p.Name} {p.Age}");
            }
            else
            {
                Person p = new Person(argument);
                Console.WriteLine($"{p.Name} {p.Age}");
            }
        }
        else if (inputArgs.Length == 2)
        {
            string name = inputArgs[0];
            int age = int.Parse(inputArgs[1]);
            Person p = new Person(name, age);
            Console.WriteLine($"{p.Name} {p.Age}");
        }

    }

    private static void CreatePersons()
    {
        Person pesho = new Person()
        {
            Name = "Pesho",
            Age = 20
        };

        Person gosho = new Person("Gosho", 18);

        Person stamat = new Person()
        {
            Name = "Stamat",
            Age = 43
        };

        Console.WriteLine($"{pesho.Name} {pesho.Age}");
        Console.WriteLine($"{gosho.Name} {gosho.Age}");
        Console.WriteLine($"{stamat.Name} {stamat.Age}");
    }
}








