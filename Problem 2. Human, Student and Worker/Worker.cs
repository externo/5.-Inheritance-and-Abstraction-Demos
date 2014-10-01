using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Human__Student_and_Worker
{
    class Worker: Human
    {
        private string firstName;
        private string lastName;
        private double weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        
        public double WeekSalary 
        {
            get 
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay 
        {
            get 
            {
                return this.workHoursPerDay;
            }
            set 
            {
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay;
        }
    }
}
