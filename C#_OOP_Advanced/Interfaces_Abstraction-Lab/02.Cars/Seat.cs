
using System.Text;

public class Seat :ICar
{

    private string model;
    private string color;

    public Seat(string model, string color)
    {
        this.Model = model;
        this.Color = color;
    }

    public string Model { get; set; }

    public string Color { get; set; }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaaak!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {this.GetType()} {this.Model}");
        sb.AppendLine(this.Start());
        sb.Append(this.Stop());
        return sb.ToString();
    }
}

