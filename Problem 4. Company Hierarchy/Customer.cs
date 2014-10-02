using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Company_Hierarchy
{
    class Customer : Person, ICostumer
    {
        private decimal netPurchaseAmount;

        public Customer(string id, string firstName, string lastName, decimal netPurchaseAmount)
            : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount 
        {
            get
            {
                return this.netPurchaseAmount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Net purchase amount should be positive number!");
                }
                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Has " + this.NetPurchaseAmount + " net purchase amount.";
        }
    }
}
