public class Rectangle
{
    public Rectangle(int id, int width, int height, double topLeftX, double topleftY)
    {
        this.Id = id;
        this.Width = width;
        this.Height = height;
        this.TopLeftX = topLeftX;
        this.TopLeftY = topleftY;
    }

    public int Id { get; set; }

    public double Width { get; set; }

    public double Height { get; set; }

    public double TopLeftX { get; set; }

    public double TopLeftY { get; set; }


    public bool CheckIntersection(Rectangle r2)
    {
        if (this.TopLeftX > r2.TopLeftX + r2.Width || r2.TopLeftX > this.TopLeftX + this.Width)
        {
            return false;
        }

        if (this.TopLeftY < r2.TopLeftY - this.Height || r2.TopLeftY < this.TopLeftY - this.Height)
        {
            return false;
        }

        return true;
    }
}
