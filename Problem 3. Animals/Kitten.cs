using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, string gender = "female")
            : base(name, age, gender)
        {

        }

        public string ProduceSound()
        {
            return "Miaauuu like a KITTEN";
        }
    }
}