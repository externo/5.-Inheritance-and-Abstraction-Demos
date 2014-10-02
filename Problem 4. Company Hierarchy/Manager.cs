using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Company_Hierarchy
{
    class Manager: Employee, IManager
    {
        private List<Employee> setOfEmployees;

        public Manager(string id, string firstName, string lastName, decimal salary, 
            Department department, List<Employee> setOfemployees)
            : base(id, firstName, lastName, salary, department)
        {
            this.SetOfEmployees = setOfemployees;
        }

        public List<Employee> SetOfEmployees 
        {
            get
            {
                return this.setOfEmployees;
            }
            set
            {
                this.setOfEmployees = value;
            }
        }
    }
}
