﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string gender = "male")
            : base(name, age, gender)
        {

        }
        public string ProduceSound()
        {
            return "Aaargh...!!!";
        }
    }
}