using System;

//sealed class MyClass
//{
//    private string msg;

//    public MyClass(string message)
//    {
//        msg = message;
//    }

//    public void SayHello()
//    {
//        Console.WriteLine(msg);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        MyClass myObj = new MyClass("Hello from MyClass!");
//        myObj.SayHello();
//        Console.ReadLine();
//    }
//}


public sealed class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }
}
class Program
{
    public static void Main()
    {
        Rectangle rectangle = new Rectangle(5.0, 10.0);
        Console.WriteLine("Rectangle Area: "+ rectangle.CalculateArea());
        Console.ReadLine();
    }
}