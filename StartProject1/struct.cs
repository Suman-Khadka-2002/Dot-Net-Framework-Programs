//using System;

//public struct Point
//{
//    public int X;
//    public int Y;

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public void Print()
//    {
//        Console.WriteLine("({0}, {1})", X, Y);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Point p1 = new Point(10, 20);
//        p1.Print();

//        Point p2 = new Point();
//        p2.X = 30;
//        p2.Y = 40;
//        p2.Print();

//        Console.ReadLine();
//    }
//}

// Enum

using System;

class Enumprgram
{
    enum Days {  Sun, Mon, Tue, Wed, Thu, Fri, Sat};
    static void Main(string[] args)
    {
        int WeekdayStart = (int)Days.Mon;
        int WeekdayEnd = (int)Days.Fri;

        Console.WriteLine("Monday: {0}", WeekdayStart);
        Console.WriteLine("Friday: {0}", WeekdayEnd);
        Console.ReadLine();

    }
}
