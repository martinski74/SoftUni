﻿using System;

class CirclePerimeterArea
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double perimeter = Math.PI * radius * 2;
        double area = Math.PI * radius * radius;
        Console.WriteLine("Perimeteris: {0:F2}", perimeter);
        Console.WriteLine("Area is: {0:F2}", area);
    }
}

