using System;

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Width = 5;
        rectangle.Height = 10;
        Console.WriteLine("Area of rectangle: {0}", rectangle.CalculateArea());

        Circle circle = new Circle();
        circle.Radius = 7;
        Console.WriteLine("Area of circle: {0}", circle.CalculateArea());

        Console.ReadLine();
    }
}
