using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab1
{
    internal class Person
    {
        private int NumofEyes;
        internal string Haircolor { get; set; }
        public int NumberofEyes { get { return NumofEyes; } set { NumofEyes = value; } } 
    }
}
