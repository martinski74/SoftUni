public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity,fuelConsumption,tankCapacity)
    {
        this.FuelConsumption += 1.6;
    }

    public override void Refuel(double litters)
    {
        base.Refuel(litters);
        this.FuelQuantity += litters * 0.95;
    }
}

