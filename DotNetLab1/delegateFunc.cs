using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab1
{
    public class Animals
    {
        public void WhatIEat()
        {
            Console.WriteLine("I eat grass.");
        }
        public void WhatIEats(string food)
        {
            Console.WriteLine("I eat " + food);
        }
    }
}
