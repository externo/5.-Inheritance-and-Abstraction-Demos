using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Company_Hierarchy
{
    class Developer: RegularEmployee
    {
        private List<Projects> setOfProjects;

        public Developer(string id, string firstName, string lastName, decimal salary, 
            Department department, List<Projects> setOfProjects)
            : base(id, firstName, lastName, salary, department)
        {
            this.SetOfProjects = setOfProjects;
        }

        public List<Projects> SetOfProjects 
        {
            get
            {
                return this.setOfProjects;
            }
            set
            {
                this.setOfProjects = value;
            }
        }
    }
}
