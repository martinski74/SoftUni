﻿
using System;


public class ShowCar : Car
{
    private int stars;
    public ShowCar( string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.Stars = 0;
    }
    public int Stars
    {
        get { return this.stars; }
        set { this.stars = value; }
    }

    public override string ToString()
    {
        var result = base.ToString() + Environment.NewLine;
        result += $"{this.Stars} *";

        return result;
    }
}

