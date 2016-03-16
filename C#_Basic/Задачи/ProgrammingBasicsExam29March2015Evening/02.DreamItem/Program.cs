using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputData = input.Split('\\');

        string month = inputData[0];
        decimal moneyPerHour = decimal.Parse(inputData[1]);
        int hoursPerDay = int.Parse(inputData[2]);
        decimal priceOfItem = decimal.Parse(inputData[3]);

        int daysOfMonth=0;
        switch (month)
        {
            case "Jan": daysOfMonth = 31; break;
            case "Feb": daysOfMonth = 28; break;
            case "March": daysOfMonth = 31; break;
            case "Apr": daysOfMonth = 30; break;
            case "May": daysOfMonth = 31; break;
            case "June": daysOfMonth = 30; break;
            case "July": daysOfMonth = 31; break;
            case "Aug": daysOfMonth = 31; break;
            case "Sept": daysOfMonth = 30; break;
            case "Oct": daysOfMonth = 31; break;
            case "Nov": daysOfMonth = 30; break;
            case "Dec": daysOfMonth = 31; break;

            default:
                break;
        }
        daysOfMonth = daysOfMonth - 10;
        decimal moneyCalc = daysOfMonth * moneyPerHour * hoursPerDay;
       
        if (moneyCalc > 700)
        {
            moneyCalc += moneyCalc * 0.1M;
        }
        if (moneyCalc-priceOfItem >= 0 )
        {
            Console.WriteLine("Money left = {0:F2} leva.", moneyCalc - priceOfItem);
        }
        else
        {
           
            Console.WriteLine("Not enough money. {0:F2} leva needed.", priceOfItem - moneyCalc);
        }
        

    }
}

