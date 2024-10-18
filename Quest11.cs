public abstract class Shape
{
    public abstract int CalculateArea();
    public abstract void DisplayShapeInfo();
}

public class Rectangle : Shape
{
    public int Length { get; set; }
    public int Width { get; set; }
    public override int CalculateArea()
    {
        return this.Length * this.Width;
    }
    public override void DisplayShapeInfo()
    {
        Console.WriteLine("This is a Rectangle love");
    }
}

public class Circle : Shape
{
    public int Radius { get; set; }
    public override int CalculateArea()
    {
        return Convert.ToInt32(this.Radius * this.Radius * 3.14);
    }
    public override void DisplayShapeInfo()
    {
        Console.WriteLine("This is a Circlef love");
    }
}

Rectangle rectangle = new Rectangle();
Circle circle = new Circle();
rectangle.Length = 5;
rectangle.Width = 2;
circle.Radius = 5;
Console.WriteLine($"{rectangle.CalculateArea()} {circle.CalculateArea()}");