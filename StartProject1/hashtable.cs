//using System;
//using System.Collections;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Hashtable mylist = new Hashtable();

//        mylist.Add("name", "suman");
//        mylist.Add("age", "20");
//        mylist.Add("College", "BMC");
//        mylist.Add("mobile", "9874973");

//        // Print the contents of the Hashtable
//        Console.WriteLine("Hashtable contents:");
//        foreach (DictionaryEntry item in mylist)
//        {
//            //Console.WriteLine("Key is " + item + " and value is " + mylist[item]);
//            Console.WriteLine(item.Key + " : " + item.Value);
//        }
//        Console.WriteLine("\n");

//        // Remove an element from the Hashtable
//        mylist.Remove("mobile");

//        // Print the contents of the Hashtable again
//        Console.WriteLine("Hashtable contents after removing mobile:");
//        foreach (DictionaryEntry item in mylist)
//        {
//            Console.WriteLine(item.Key + ": " + item.Value);
//        }

//        Console.ReadLine();
//    }
//}
