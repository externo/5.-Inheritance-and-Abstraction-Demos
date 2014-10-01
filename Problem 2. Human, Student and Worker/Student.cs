using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Human__Student_and_Worker
{
    class Student: Human
    {
        private string firstName;
        private string lastName;
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
        }

        public override string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public override string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public string FacultyNumber 
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value.Length >=5 && value.Length <= 10)
                {
                    this.facultyNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Faculty number length should be in range 5..10 symbols");
                }
            }
        }
    }
}
