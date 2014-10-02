using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Company_Hierarchy
{
    class RegularEmployee: Employee, IRegularEmployee
    {
        public RegularEmployee(string id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName, salary, department) { }
    }
}
