//// Abstract class declaration
//using System;

//public abstract class Shape
//{
//    // Abstract method with no implementation
//    public abstract double CalculateArea();

//    // Non-abstract method with implementation
//    public void DisplayArea()
//    {
//        Console.WriteLine($"Area: {CalculateArea()}");
//    }
//}

//// Concrete class inheriting from the abstract class
//public class Circle : Shape
//{
//    public double Radius { get; set; }

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }

//    // Implementation of the abstract method
//    public override double CalculateArea()
//    {
//        return Math.PI * Radius * Radius;
//    }
//}

//class Program
//{
//    public static void Main()
//    {
//        // Cannot create an instance of the abstract class directly
//        // Shape shape = new Shape(); // Error: Cannot create an instance of the abstract class

//        // Create an instance of the concrete class Circle
//        Circle circle = new Circle(5.0);
//        circle.DisplayArea();
//        Console.ReadLine();
//    }
//}
