using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Company_Hierarchy
{
    class Employee : Person, IEmployee
    {
        //salary and department
        private decimal salary;
        private Department department;

        public Employee(string id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary 
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }

        public Department Department 
        {
            get
            {
                return this.department;
            }
            set
            {
                this.department = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Has " + this.Salary + " and " + this.Department + " department.";
        }
    }
}
