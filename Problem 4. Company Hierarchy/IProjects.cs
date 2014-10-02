using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Company_Hierarchy
{
    interface IProjects
    {
        //project name, project start date, details and a state (open or closed). A project can be closed through the method CloseProject().
        string Name { get; set; }

        DateTime StartDate { get; set; }

        string Details { get; set; }

        string State { get; set; }

        void CloseProject();
    }
}
