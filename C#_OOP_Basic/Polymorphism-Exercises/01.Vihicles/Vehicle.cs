using System;

public abstract class Vehicle
{
    private double fuelQuantity;
    private double fuelConsumption;

    protected Vehicle(double fuelQuantity, double fuelConsumption)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
    }

    public double FuelQuantity
    {
        get { return this.fuelQuantity; }
        protected set
        {
            if (value < 0)
            {
                throw new InvalidOperationException($"{this.GetType()} needs refueling");
            }
            this.fuelQuantity = value;
        }
    }

    public double FuelConsumption
    {
        get { return this.fuelConsumption; }
        protected set
        {
            this.fuelConsumption = value;
        }
    }

    public void Drive(double distance)
    {
        var litters = distance * this.FuelConsumption;
        this.FuelQuantity -= litters;
    }

    public abstract void Refuel(double litters);

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.fuelQuantity:f2}";
    }
}