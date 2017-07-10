using System;

public abstract class Vehicle
{
    private double fuelQuantity;
    private double fuelConsumption;
    private double tankCapacity;

    protected Vehicle(double fuelQuantity, double fuelConsumption,double tankCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
        this.TankCapacity = tankCapacity;
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

    public double TankCapacity
    {
        get
        {
            return this.tankCapacity;
        }
        protected set
        {
            this.tankCapacity = value;
        }
    }

    public virtual void Refuel(double litters)
    {
        if (litters <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.fuelQuantity:f2}";
    }
}