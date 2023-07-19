using System;
namespace MyNamespace
{
    public class MyClass
    {
        public void MyMethod() 
        {
            Console.WriteLine("Hello from MyMethod.");
            Console.ReadLine();
        }

    }
}
class Program
{
    public static void Main()
    {
        MyNamespace.MyClass obj1 = new MyNamespace.MyClass();
        obj1.MyMethod();
    }
}