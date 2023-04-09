using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab1
{
    internal class PersonC
    {
        private string name;
        private int age;

        public PersonC(string n, int a)
        {
            name = n;
            age = a;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old.");

        }
    }
}

