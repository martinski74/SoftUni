
public class FireBender : Bender
{
    private double heatAggression;

    public FireBender(string name, int power,double heatAggression)
    : base(name, power)
    {
        this.heatAggression = heatAggression;
    }
    public override double GetPower() => this.heatAggression * base.Power;

    public override string ToString() =>
        $"###Fire Bender: {this.Name}, Power: {this.Power}, Heat Aggression: {this.heatAggression:f2}";

}

