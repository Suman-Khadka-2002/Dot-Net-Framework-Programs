using System;

interface IShape
{
    void Draw();
}

interface IColor
{
    void Colorize();
}

class Circle : IShape, IColor
{
    public void Draw()
    {
        Console.WriteLine("Circle is drawn.");
    }

    public void Colorize()
    {
        Console.WriteLine("Circle is colorized.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        circle.Draw();
        circle.Colorize();
        Console.ReadLine();
    }
}
