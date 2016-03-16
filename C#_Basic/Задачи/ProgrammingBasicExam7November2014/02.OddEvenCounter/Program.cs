using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] letters = input.ToCharArray();
        int n = int.Parse(Console.ReadLine());

        int counter = 0;
        bool hasResult = false;
        foreach (char c in letters)
        {
            foreach (char c1 in letters)
            {
                foreach (char c2 in letters)
                {
                    foreach (char c3 in letters)
                    {
                        foreach (char c4 in letters)
                        {
                           
                            if (counter == n)
                            {
                                string result = c + "" + c1 + "" + c2 + "" + c3 + "" + c4;
                                Console.WriteLine(result);
                                hasResult = true;
                            }
                            counter++;
                        }
                    }
                }
            }
        }
        if (!hasResult)
        {
            Console.WriteLine("No");
        }

    }
}

