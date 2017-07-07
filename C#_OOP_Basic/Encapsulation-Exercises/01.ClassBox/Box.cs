
using System.Text;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Surface Area - {((2 * this.length * this.width) + (2 * this.length * this.height) + (2 * width * height)):f2}");
        sb.AppendLine($"Lateral Surface Area - {((2 * this.length * this.height) + (2 * this.width * this.height)):f2}");
        sb.Append($"Volume - {(this.length * this.height * this.width):f2}");

        return sb.ToString();
    }
}

