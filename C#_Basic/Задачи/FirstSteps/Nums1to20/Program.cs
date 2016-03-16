using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main()
    {
        string date = Console.ReadLine();
        string format = "dd-MM-yyyy";
       
        DateTime result = DateTime.ParseExact(date,format,null);
        Console.WriteLine(result.AddDays(999).ToString("dd-MM-yyyy"));
          
        
       
    }
}

