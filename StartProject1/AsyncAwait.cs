//using System;
//using System.Threading.Tasks;

//class Program
//{
//    static async Task Main(string[] args)
//    {

//        Console.WriteLine("Starting the program.\n");
//        Function1();
//        Function2();
  
//        Console.WriteLine("\nProgram complete.");
//        Console.ReadLine();
//    }

//    public static async Task Function1()
//    {
//        await Task.Run(() =>
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Function1");
//                Task.Delay(100).Wait();
//            }
//        });
//    }
//    public static void Function2()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine("I am from Function2");
//            Task.Delay(100).Wait();
//        }
//    }
//}
