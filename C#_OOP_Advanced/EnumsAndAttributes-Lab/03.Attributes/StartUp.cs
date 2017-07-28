using System;
using System.Collections.Generic;

[SoftUni("Ventsi")]

public class StartUp
{
    [SoftUni("Gosho")]
    public static void Main()
    {
        var tracker = new Tracker();
        tracker.PrintMethodsByAuthor();
    }
}

