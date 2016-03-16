using System;

class Program
{
    static void Main()
    {
        int orders = int.Parse(Console.ReadLine());
 
        double totalCost=0;
        double tottalAllCost = 0;
        int allTotalBooks = 0;

        for (int i = 0; i < orders; i++)
        {
            int numberOfPackets = int.Parse(Console.ReadLine());
            int booksPerPacket = int.Parse(Console.ReadLine());
            double bookPrice = double.Parse(Console.ReadLine());

            double discount = 0;
            int allBooks = numberOfPackets * booksPerPacket;
            allTotalBooks += allBooks;

            if (numberOfPackets < 10)
            {
                discount = bookPrice;
            }
            else if (numberOfPackets >= 10 && numberOfPackets <= 19)
            {
                discount = bookPrice - (bookPrice * 5) / 100;
            }
            else if (numberOfPackets >= 20 && numberOfPackets <= 29)
            {
                discount = bookPrice - (bookPrice * 6) / 100;
            }
            else if (numberOfPackets >= 30 && numberOfPackets <= 39)
            {
                discount = bookPrice - (bookPrice * 7) / 100;
            }
            else if (numberOfPackets >= 40 && numberOfPackets <= 49)
            {
                discount = bookPrice - (bookPrice * 8) / 100;
            }
            else if (numberOfPackets >= 50 && numberOfPackets <= 59)
            {
                discount = bookPrice - (bookPrice * 9) / 100;
            }
            else if (numberOfPackets >= 60 && numberOfPackets <= 69)
            {
                discount = bookPrice - (bookPrice * 10) / 100;
            }
            else if (numberOfPackets >= 70 && numberOfPackets <= 79)
            {
                discount = bookPrice - (bookPrice * 11) / 100;
            }
            else if (numberOfPackets >= 80 && numberOfPackets <= 89)
            {
                discount = bookPrice - (bookPrice * 12) / 100;
            }
            else if (numberOfPackets >= 90 && numberOfPackets <= 99)
            {
                discount = bookPrice - (bookPrice * 13) / 100;
            }
            else if (numberOfPackets >= 100 && numberOfPackets <= 109)
            {
                discount = bookPrice - (bookPrice * 14) / 100;
            }
            else
            {
                discount = bookPrice - (bookPrice * 15) / 100;
            }
            
            totalCost = allBooks * discount;
            tottalAllCost += totalCost;
        }


        Console.WriteLine(allTotalBooks);
        Console.WriteLine("{0:F2}", tottalAllCost);
    }
}

