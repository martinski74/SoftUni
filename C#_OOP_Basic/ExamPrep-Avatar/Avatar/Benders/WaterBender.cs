
public class WaterBender : Bender
{
    private double waterClarity;

    public WaterBender(string name, int power,double waterClarity)
    : base(name, power)
    {
        this.waterClarity = waterClarity;
    }
    public override double GetPower() => this.waterClarity * base.Power;

    public override string ToString() =>
        $"###Water Bender: {this.Name}, Power: {this.Power}, Water Clarity: {this.waterClarity:f2}";
}

