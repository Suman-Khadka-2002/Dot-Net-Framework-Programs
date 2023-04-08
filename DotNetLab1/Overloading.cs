

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab1
{

    public class Animal
    {
        public void WhatIEat()
        {
            Console.WriteLine("I eat grass.");
        }
        public void WhatIEat(string food)
        {
            Console.WriteLine("I eat " + food);
        }
        public void WhatIEat(string food1, string food2)
        {
            Console.WriteLine("I eat " + food1 + " and " + food2 + ".");
        }
    }

}

