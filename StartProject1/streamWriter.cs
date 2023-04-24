using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter text to write to file: ");
        string input = Console.ReadLine();

        // Open the file for writing
        using (StreamWriter writer = new StreamWriter("E:\\. NET programs\\StartProject1\\output.txt"))
        {
            // Write the user input to the file
            writer.WriteLine(input);
        }

        Console.WriteLine("Text written to file.");
        Console.ReadLine();
    }
}
