var rectangle = new Rectangle(200, 300);
var inmutableRectangle = new InmutableRectangle(200, 300);

public struct Rectangle
{
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Width { get; set; }
    public double Height { get; set; }
}

public readonly struct InmutableRectangle
{
    public InmutableRectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Width { get; init; }
    public double Height { get; init; }
}
