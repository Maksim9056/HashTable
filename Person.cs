using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
 public   class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override int GetHashCode()
        {
            return Name.Length + Age + Gender + (int)Name[0];
        }
    }
}
