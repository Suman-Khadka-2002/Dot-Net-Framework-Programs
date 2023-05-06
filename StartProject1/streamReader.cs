// File I/O : streamReader 

using System;
using System.IO;
class Program
{
    static void Main()
    {
        // Open the file for reading
        using (StreamReader reader = new StreamReader("E:\\. NET programs\\StartProject1\\output.txt"))
        {
            // Read the contents of the file and write them to the console
            string contents = reader.ReadToEnd();
            Console.WriteLine(contents);
        }
        Console.WriteLine("\nText is read.");
        Console.ReadKey(); 
    }
}
