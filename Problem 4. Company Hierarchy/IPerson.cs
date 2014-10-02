using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Company_Hierarchy
{
    interface IPerson
    {
        //id, first name and last name
        string Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }
    }
}
