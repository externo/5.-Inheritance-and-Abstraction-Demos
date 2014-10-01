using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.School
{
    class Student: Person
    {
        public int ClassNumber { get; set; }

        public Student(string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }
    }
}
