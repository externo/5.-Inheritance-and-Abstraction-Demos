using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Company_Hierarchy
{
    class Person : IPerson
    {
        //id, first name and last name
        private string id;
        private string firstName;
        private string lastName;

        public Person(string id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        string ID 
        { 
            get 
            {
                return this.id;
            } 
            set
            {
                this.id = value;
            } 
        }

        string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return this.GetType() + ": " + this.FirstName + " " + this.LastName + " has ID " + this.ID;
        }
    }
}
