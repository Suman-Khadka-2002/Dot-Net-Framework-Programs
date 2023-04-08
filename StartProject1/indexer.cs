using System;

public class MyCollection
{
    private string[] items = new string[5];

    public string this[int index]
    {
        get { return items[index]; }
        set { items[index] = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyCollection collection = new MyCollection();
        collection[0] = "apple";
        collection[1] = "banana";
        collection[2] = "cherry";

        Console.WriteLine("Items in collection:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(collection[i]);
        }

        Console.ReadLine();
    }
}
