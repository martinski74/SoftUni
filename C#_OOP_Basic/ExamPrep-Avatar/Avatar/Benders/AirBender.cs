
public class AirBender : Bender
{
    private double aerialIntegrity;

    public AirBender(string name, int power,double aerialIntegrity)
    : base(name, power)
    {
        this.aerialIntegrity = aerialIntegrity;
    }

    public override double GetPower() => this.aerialIntegrity * base.Power;

    public override string ToString() =>
        $"###Air Bender: {this.Name}, Power: {this.Power}, Aerial Integrity: {this.aerialIntegrity:f2}";

}

