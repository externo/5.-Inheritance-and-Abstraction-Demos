using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.School
{
    struct Class
    {
        public string Identifier { get; set; }
        public List<Teacher> Teachers { get; set; }

        public Class(string identifier, List<Teacher> teachers)
        {
            this.Identifier = identifier;
            this.Teachers = teachers;
        }
    }
}
