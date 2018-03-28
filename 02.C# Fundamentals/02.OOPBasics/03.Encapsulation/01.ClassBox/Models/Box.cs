public class Box
{
    public Box(double lenght, double width, double height)
    {
        this.Lenght = lenght;
        this.Width = width;
        this.Height = height;
    }


    public double Lenght { get; set; }

    private double Width { get; set; }

    public double Height { get; set; }


    public double CalcSurfaceArea(double lenght, double width, double height)
    {
        var result = (2 * lenght * width) + (2 * lenght * height) + (2 * width * height);
        return result;
    }

    public double CalcLateralSurfaceArea(double lenght, double width, double height)
    {
        var result = (2 * lenght * height) + (2 * width * height);
        return result;
    }

    public double CalcVolume(double lenght, double width, double height)
    {
        var result = lenght * width * height;
        return result;
    }

    public override string ToString()
    {
        return $"Surface Area - {this.CalcSurfaceArea(this.Lenght, this.Width, this.Height):f2}\n" +
               $"Lateral Surface Area - {this.CalcLateralSurfaceArea(this.Lenght, this.Width, this.Height):f2}\n" +
               $"Volume - {this.CalcVolume(this.Lenght, this.Width, this.Height):f2}";
    }
}

