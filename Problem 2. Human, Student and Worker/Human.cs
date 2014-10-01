using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Human__Student_and_Worker
{
    abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName(string FirstName, string LastName)
        {
            return string.Format("My name is: {0} {1}.", this.FirstName, this.LastName);
        }
    }
}
