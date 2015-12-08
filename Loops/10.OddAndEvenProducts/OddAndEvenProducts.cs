using System;

class OddAndEvenProducts
{
    static void Main()
    {
        Console.Write("Enter numbers separeted by space: ");
        string[] numbers = Console.ReadLine().Split();
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumb = int.Parse(numbers[i]);
            if (i % 2 == 0)
            {
                evenProduct = evenProduct * currentNumb; //even
            }
            else
            {
                oddProduct = oddProduct * currentNumb; //odd

            }
        }
        if (oddProduct==evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product= {0}",evenProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd-product= {0}",oddProduct);
            Console.WriteLine("even_product= {0}",evenProduct);
        }
    }
}

