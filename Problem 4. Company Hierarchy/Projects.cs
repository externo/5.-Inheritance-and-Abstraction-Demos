using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Company_Hierarchy
{
    class Projects
    {
        private string name;
        private DateTime startDate;
        private string details;
        private string state;

        public Projects(string name, DateTime startDate, string details, string state = "open")
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.State = state;
        }

        string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            } 
        }

        DateTime StartDate
        {
            get
            {
                return this.startDate;
            }
            set
            {
                this.startDate = value;
            }
        }

        string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                this.details = value;
            }
        }

        string State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        public void CloseProject()
        {
            this.State = "closed";
        }
    }
}
