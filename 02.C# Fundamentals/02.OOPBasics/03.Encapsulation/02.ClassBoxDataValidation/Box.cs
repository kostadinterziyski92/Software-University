using System;

public class Box
{
    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }


    private double length;
    private double width;
    private double height;

    public double Height
    {
        get { return height; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
            }
            this.height = value;
        }
    }


    public double Width
    {
        get { return width; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
            }
            this.width = value;
        }
    }


    public double Length
    {
        get { return length; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
            }
            this.length = value;
        }
    }



    public double CalcSurfaceArea(double length, double width, double height)
    {
        var result = (2 * length * width) + (2 * length * height) + (2 * width * height);
        return result;
    }

    public double CalcLateralSurfaceArea(double length, double width, double height)
    {
        var result = (2 * length * height) + (2 * width * height);
        return result;
    }

    public double CalcVolume(double length, double width, double height)
    {
        var result = length * width * height;
        return result;
    }

    public override string ToString()
    {
        return $"Surface Area - {this.CalcSurfaceArea(this.Length, this.Width, this.Height):f2}\n" +
               $"Lateral Surface Area - {this.CalcLateralSurfaceArea(this.Length, this.Width, this.Height):f2}\n" +
               $"Volume - {this.CalcVolume(this.Length, this.Width, this.Height):f2}";
    }
}

