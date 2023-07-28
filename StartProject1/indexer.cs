//using System;

//public class MyCollection
//{
//    private string[] items = new string[5];

//    public string this[int index]
//    {
//        get { return items[index]; }
//        set { items[index] = value; }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        MyCollection collection = new MyCollection();
//        collection[0] = "apple";
//        collection[1] = "banana";
//        collection[2] = "cherry";

//        Console.WriteLine("Items in collection:");
//        for (int i = 0; i < 3; i++)
//        {
//            Console.WriteLine(collection[i]);
//        }

//        Console.ReadLine();
//    }
//}

using System;

class SampleCollection<T>
{
    // Declare an array to store the data elements.
    private T[] arr = new T[100];

    // Define the indexer to allow client code to use [] notation.
    public T this[int i]
    {
        get { return arr[i]; }
        set { arr[i] = value; }
    }
}

class Program
{
    static void Main()
    {
        var stringCollection = new SampleCollection<string>();
        stringCollection[0] = "Hello, World";
        Console.WriteLine(stringCollection[0]);
        Console.ReadLine();
    }
}