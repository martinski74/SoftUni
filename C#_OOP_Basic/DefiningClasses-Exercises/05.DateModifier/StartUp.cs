using System;
using System.Collections.Generic;
using System.Linq;


public class StartUp
{
    public static void Main()
    {
        var firstDate = Console.ReadLine();
        var secondDate = Console.ReadLine();

        Console.WriteLine(DateModifier.GetDaysDifferent(firstDate,secondDate));
    }
}

