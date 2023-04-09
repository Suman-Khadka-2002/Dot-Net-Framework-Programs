//using System;
//using System.IO;
//using System.IO.Pipes;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string filePath = @"E:\. NET programs\StartProject1\file.txt";

//        using (FileStream file = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
//        {
//            // Convert string to bytes
//            string message = "Hello, World!";
//            byte[] messageBytes = System.Text.Encoding.UTF8.GetBytes(message);

//            // Write bytes to file
//            file.Write(messageBytes, 0, messageBytes.Length);
//        }

//        Console.WriteLine("File created and message written.");

//        Console.ReadLine();
//    }
//}
