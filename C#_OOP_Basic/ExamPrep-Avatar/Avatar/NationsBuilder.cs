using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, Nation> nations;
    private List<string> wars;


    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>()
        {
            {"Air", new Nation()},
            {"Fire", new Nation()},
            {"Earth",new Nation() },
            {"Water", new Nation() }
        };
        this.wars = new List<string>();

    }


    public void AssigneBender(List<string> benderArgs)
    {
        string benderType = benderArgs[0];
        string name = benderArgs[1];
        int power = int.Parse(benderArgs[2]);
        double secondaryParameter = double.Parse(benderArgs[3]);
        Bender bender = this.GetBender(benderType, name, power, secondaryParameter);
        this.nations[benderType].AddBender(bender);
    }

    private Bender GetBender(string type, string name, int power, double secondaryParameter)
    {
        switch (type)
        {
            case "Air":
                return new AirBender(name, power, secondaryParameter);
            case "Water":
                return new WaterBender(name, power, secondaryParameter);
            case "Fire":
                return new FireBender(name, power, secondaryParameter);
            case "Earth":
                return new EarthBender(name, power, secondaryParameter);

            default:
                throw new ArgumentException("There is no such type bender (from bender factory)");
        }
    }

    public void AssignMonument(List<string> commParams)
    {
        string monumentType = commParams[0];
        string name = commParams[1];
        int affinity = int.Parse(commParams[2]);
        Monument monument = this.GetMonument(monumentType, name, affinity);
        this.nations[monumentType].AddMonument(monument);
    }

    private Monument GetMonument(string type, string name, int secondaryParameter)
    {
        switch (type)
        {
            case "Air":
                return new AirMonument(name, secondaryParameter);
            case "Water":
                return new WaterMonument(name, secondaryParameter);
            case "Fire":
                return new FireMonument(name, secondaryParameter);
            case "Earth":
                return new EarthMonument(name, secondaryParameter);

            default:
                throw new ArgumentException("There is no such type monument (from bender factory)");
        }
    }

    public string GetStatus(string nationsType)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{nationsType} Nation");
        sb.AppendLine(nations[nationsType].ToString());
        return sb.ToString().Trim();
    }

    public void IssueWar(string nationsType)
    {
        this.wars.Add(nationsType);
        var result = nations.Values.OrderByDescending(x => x.GetTotalPower()).Skip(1).Take(3).ToList();
        foreach (var nation in result)
        {
            nation.DeclareDeeat();
        }
    }

    public string GetWarsRecord()
    {
        StringBuilder sb = new StringBuilder();
        int num = 1;

        foreach (string initiatorWar in wars)
        {
            sb.AppendLine($"War {num} issued by {initiatorWar}");
            num++;
        }
        return sb.ToString().Trim();
    }


}
