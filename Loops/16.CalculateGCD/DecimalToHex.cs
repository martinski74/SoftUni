using System;

class DecimalToHex
{
    static void Main()
    {
        long decimalNumb = long.Parse(Console.ReadLine());
        string hexNumber = string.Empty;

        if (decimalNumb == 0)
        {
            hexNumber = "0";
        }
        else
        {
            while (decimalNumb > 0)
            {
                long remind = decimalNumb % 16;
                decimalNumb /= 16;
                switch (remind)
                {
                    case 10: hexNumber = "A" + hexNumber; break;
                    case 11: hexNumber = "B" + hexNumber; break;
                    case 12: hexNumber = "C" + hexNumber; break;
                    case 13: hexNumber = "D" + hexNumber; break;
                    case 14: hexNumber = "E" + hexNumber; break;
                    case 15: hexNumber = "F" + hexNumber; break;
                    default: hexNumber = remind + hexNumber; break;
                   
                }


            }
            Console.WriteLine(hexNumber);
        }
    }
}

