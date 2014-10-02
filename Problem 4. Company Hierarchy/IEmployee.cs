using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Company_Hierarchy
{
    class IEmployee
    {
        //salary and department
        double Salary { get; set; }

        string Department { get; set; }

        HashSet<object> set { get; set; }
    }
}
