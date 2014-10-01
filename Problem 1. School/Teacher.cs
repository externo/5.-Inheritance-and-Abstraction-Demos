using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.School
{
    class Teacher: Person
    {
        public List<Discipline> Disciplines { get; set; }

        public Teacher(string name)
            : base(name)
        {

        }
    }
}
