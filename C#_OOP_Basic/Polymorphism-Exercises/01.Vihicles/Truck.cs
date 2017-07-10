public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption)
        : base(fuelQuantity,fuelConsumption)
    {
        this.FuelConsumption += 1.6;
    }

    public override void Refuel(double litters)
    {
        this.FuelQuantity += litters * 0.95;
    }
}

