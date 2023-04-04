using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab1
{
    internal class Program
    {
        public delegate void WhatIEat();
        public delegate void WhatIEats(string food);

        static void Main(string[] args)
        {
            Animals cow = new Animals();
            Animals dog = new Animals();


            WhatIEat eat = new WhatIEat(cow.WhatIEat);
            WhatIEats eats = new WhatIEats(dog.WhatIEats);

            eat();
            eats("bone");
            
            




            // file IO
            /*
            FileStream file = new FileStream("myfile.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //file.WriteByte((byte)10);
            Console.WriteLine(file.ReadByte() + "");
            file.Close();
            */

            //List 
            /*
            List<int> list= new List<int>();
            list.Add(1001);
            list.Add(1002);
            list.Add(1003);

            foreach(var item in list)
            {
                Console.WriteLine("Roll No. : " + item);
            }
            */

            /*
            Hashtable mylist = new Hashtable();
            mylist.Add("College", "BMC");
            mylist.Add("mobile", "9874973");

            foreach (var item in mylist.Keys) 
            {
                Console.WriteLine("Key is " + item + " and value is " + mylist[item]);
            }
            */

            /*
            ArrayList mylist = new ArrayList();
            mylist.Add("BMC");
            mylist.Add(1234);
            mylist.Add("Ab-2");
            mylist.Add("hello cutie");
            
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
            */

           /*
            Indexer indexer = new Indexer();
            indexer[0] = "Suman";
            indexer[1] = "Utsav";
            indexer[2] = "Ronit";

            indexer.collge = "BMC";
            for (int counter=0; counter<=2; counter++)
            {
                Console.WriteLine(indexer[counter]);
                Console.WriteLine(indexer.collge);

            }
           */
            
        /* Overloading
        
            Animal Cow = new Animal();
            Cow.WhatIEat();
            Cow.WhatIEat("grass");
            Cow.WhatIEat("grass", "straw");
          */  

            // Try...catch 
            /*
            try
            {
                string[] names = new string[5];
                names[0] = "Suman";
                names[1] = "Utsav";
                names[2] = "Ronit";
                names[3] = "Bipin";
                names[4] = "Bishow";
                //names[5] = "Bishow";

                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong");
            }
            Console.ReadKey();
            */


            // string to integer
            /*
            try
            {
                Console.WriteLine("Enter a number: ");
                string numb = Console.ReadLine();
                int numA = Convert.ToInt32(numb);
                Console.WriteLine("Your number is {0}.", numA);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);    
            }
            */


            // code for Person class 
            /*    
            Person Suman = new Person();
            Suman.Haircolor = "black";
            Suman.NumberofEyes = 2;
            Console.WriteLine("Suman has " + Suman.NumberofEyes + " eyes.");
            Console.WriteLine("Suman has " + Suman.Haircolor + " hair color.");
            */

        //LogicalOperator();
        //BitwiseOperator();
        //BitwiseShift();
            Console.ReadKey();
        }

        /*
        static void LogicalOperator()
        {
            Console.WriteLine("Enter your College name: ");
            string collgeName = Console.ReadLine();
            Console.WriteLine("Enter your Program: ");
            string programName = Console.ReadLine();

            if (collgeName.ToUpper() == "BMC" && programName.ToUpper() == "CSIT")
            {
                Console.WriteLine("You are welcome in Lab.");
            }
            else
            {
                Console.WriteLine("You may not enter.");
            }
        }
        */

        /*
        static void BitwiseOperator()
        {
            Console.WriteLine("Enter first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int SecondNum = Convert.ToInt32(Console.ReadLine());

            int result_and = firstNum & SecondNum;
            Console.WriteLine("Bitwise AND Operation between firstNum and SecondNum: ");
            Console.WriteLine(result_and);  
            
            int result_or = firstNum | SecondNum;
            Console.WriteLine("Bitwise OR Operation between firstNum and SecondNum: ");
            Console.WriteLine(result_or);  
        
            int result_xor = firstNum ^ SecondNum;
            Console.WriteLine("Bitwise XOR Operation between firstNum and SecondNum: ");
            Console.WriteLine(result_xor);            
        
        
            int result_complement = ~firstNum;
            Console.WriteLine("Bitwise Complement Operation of firstNum: ");
            Console.WriteLine(result_complement);            
        }
        */

        /*
        static void BitwiseShift()
        {
            int number = 20;
            Console.WriteLine("{0}<<1 = {1}", number, number << 1);
            Console.WriteLine("{0}<<2 = {1}", number, number << 2);
            Console.WriteLine("{0}<<3 = {1}", number, number << 3);
            Console.WriteLine("{0}<<4 = {1}", number, number << 4);


            Console.WriteLine("{0}>>2 = {1}", number, number >> 2);
        } 
        */
    }
}
