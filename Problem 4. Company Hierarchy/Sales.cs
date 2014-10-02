using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Company_Hierarchy
{
    class Sales: Department
    {
        //product name, date and price
        public string Name { get; set; }

        public DateTime Date { get; set; }
        
        public double Price { get; set; }
    }
}
