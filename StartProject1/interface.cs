//using System;

//public interface IShape
//{
//    double CalculateArea();
//}

//public class Circle : IShape
//{
//    private double radius;

//    public Circle(double radius)
//    {
//        this.radius = radius;
//    }

//    public double CalculateArea()
//    {
//        return Math.PI * Math.Pow(radius, 2);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        IShape shape = new Circle(5);
//        Console.WriteLine("Area of circle: {0}", shape.CalculateArea());
//        Console.ReadLine();
//    }
//}


// Another example of interface

//using System;

//public interface Iplayable
//{
//    void Play();
//    void Pause();
//    void Stop();
//}
//// Implementing interface in class
//public class MusicPlayer : Iplayable
//{
//    public void Play()
//    {
//        Console.WriteLine("Music is playing.");
//    }
//    public void Pause()
//    {
//        Console.WriteLine("Music is paused.");
//    }
//    public void Stop()
//    {
//        Console.WriteLine("Music is stopped.");
//    }
//}

//class Program
//{
//    public static void Main()
//    {
//        Iplayable iplayable = new MusicPlayer();
//        iplayable.Play();
//        iplayable.Pause();
//        iplayable.Stop();
//        Console.ReadLine();
//    }
//}