using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral :Private,ILeutenantGeneral
{
    public LeutenantGeneral(string id, string firstName, string lastName, double salary, IList<ISoldier> soldiers)
        : base(id, firstName, lastName, salary)
    {
        this.Soldiers = soldiers;
    }

    public IList<ISoldier> Soldiers { get; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine("Privates:");
        for (int i = 0; i < this.Soldiers.Count; i++)
        {
            sb.AppendLine($"  {this.Soldiers[i].ToString()}");
        }

        return sb.ToString().Trim();
    }
}

