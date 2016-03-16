using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1--> int");
        Console.WriteLine("2--> double");
        Console.WriteLine("3--> string");
        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1: Console.Write("Please enter a int: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(n);
                break;
            case 2: Console.Write("Please enter a double:");
                double numb = double.Parse(Console.ReadLine());
                Console.WriteLine(numb);
                break;
            case 3: Console.WriteLine("Please enter a string: ");
                string word = Console.ReadLine();
                Console.WriteLine(word + "*");
                break;

            default: Console.WriteLine("iNVALID INPUT!");
                break;
        }
    }
}

