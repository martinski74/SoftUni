using System;

class Program
{
    static void Main()
    {
        string dayOfWeek = Console.ReadLine();
        decimal sum = 0;
        for (int i = 0; i < 3; i++)
        {
            decimal quantity = decimal.Parse(Console.ReadLine());
            string product = Console.ReadLine();
            decimal price = 0;
            bool isFruit = false;
           
            switch (product)
            {
                case "banana": price = 1.80M; isFruit = true;
                    break;
                case "cucumber": price = 2.75M;
                    break;
                case "tomato": price = 3.20M;
                    break;
                case "orange": price = 1.60M; isFruit = true;
                    break;
                case "apple": price = 0.86M; isFruit = true;
                    break;
            }
            decimal totalPrice = quantity * price;
            switch (dayOfWeek)
            {
                case "Friday": totalPrice *= 0.9m;
                    break;
                case "Sunday": totalPrice *= 0.95M;
                    break;
                case "Tuesday": if (isFruit)
                    {
                        totalPrice *= 0.8M;
                    }
                    break;
                case "Wednesday": if (!isFruit)
                    {
                        totalPrice *= 0.9M;
                    }
                    break;
                case "Thursday": if (product == "banana")
                    {
                        totalPrice *= 0.7m;
                    }
                    break;

            }
            sum += totalPrice;
            
        }
        Console.WriteLine("{0:F2}",sum);

       

    }
}

