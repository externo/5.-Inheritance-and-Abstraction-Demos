using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.School
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }
    
        public void SayName()
        {
            Console.WriteLine("My name is: " + this.Name);
        }
    }
}
