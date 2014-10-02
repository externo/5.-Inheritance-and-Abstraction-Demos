using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Company_Hierarchy
{
    class SalesEmployee: RegularEmployee, ISalesEmployee
    {
        //set of sales. A sale holds product name, date and price.
        private List<Sale> setOfSales;

        public SalesEmployee(string id, string firstName, string lastName, decimal salary, 
            Department department, List<Sale> setOfSales)
            : base(id, firstName, lastName, salary, department)
        {
            this.SetOfSales = setOfSales;
        }

        public List<Sale> SetOfSales 
        {
            get
            {
                return this.setOfSales;
            }
            set
            {
                this.setOfSales = value;
            }
        }
    }
}
