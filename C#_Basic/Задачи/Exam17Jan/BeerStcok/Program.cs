using System;

class Program
{
    static void Main()
    {
        long reservedBeers = long.Parse(Console.ReadLine());
        string command = Console.ReadLine();
        
        long totalBeers = 0;
        long neededBeers = 0;
        long cases = 0;
        long sixpax = 0;
        long beerLeft = 0;
       
        while (command != "Exam Over")
        {
            string[] amountType = command.Split(' ');
            long amount = long.Parse(amountType[0]);
            string type = amountType[1];
           
            switch (type)
            {
                case "beers": totalBeers += amount;
                    break;
                case "cases": totalBeers += amount * 24;
                    break;
                case "sixpacks": totalBeers += amount * 6;
                    break;
            }

            command = Console.ReadLine();
        }
       totalBeers=totalBeers-(totalBeers/100);
          
                if (totalBeers >=reservedBeers)
                {
                    neededBeers = totalBeers - reservedBeers;
                    cases = neededBeers / 24;
                    neededBeers = neededBeers % 24;
                    sixpax = neededBeers / 6;
                    beerLeft = neededBeers % 6;
                    Console.WriteLine(
                   "Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", cases, sixpax, beerLeft);
                }
                else
                {
                  
                    neededBeers = reservedBeers - totalBeers;
                    cases = neededBeers / 24;
                    neededBeers = neededBeers % 24;
                    sixpax = neededBeers / 6;
                    beerLeft = neededBeers % 6;
                    Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", cases, sixpax, beerLeft);

                }
               
               

          

        }


    }


