using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.School
{
    struct Discipline
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public List<string> Lectures { get; set; }
        public Student Students { get; set; }

        public Discipline(string name, int number, List<string> lectures, Student students)
        {
            this.Name = name;
            this.Number = number;
            this.Lectures = lectures;
            this.Students = students;
        }
    }
}
